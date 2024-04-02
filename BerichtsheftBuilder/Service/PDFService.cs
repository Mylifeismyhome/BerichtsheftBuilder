using BerichtsheftBuilder.Dto;
using BerichtsheftBuilder.service;
using Microsoft.Extensions.DependencyInjection;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using System;
using System.Collections.Generic;

namespace BerichtsheftBuilder.Service
{
    public class PDFService
    {
        private ProfileService profileService = Program.ServiceProvider.GetService<ProfileService>();

        public void generate(string path, string fontFamily = "Helvetica")
        {
            ProfileDto profile = profileService.Profile;

            Document.Create(container =>
            {
                DateTime tmpAusbildungsstart = profile.Ausbildungsstart;
                int year = 1;
                DateTime yearEnd = tmpAusbildungsstart.AddYears(1);
                while (tmpAusbildungsstart.CompareTo(profile.Ausbildungsend) <= 0)
                {
                    DateDto kalenderwoche = DateDto.GetCalendarWeek(tmpAusbildungsstart);

                    if (kalenderwoche.WeekStartDate.CompareTo(profile.Ausbildungsstart) < 0)
                    {
                        kalenderwoche.WeekStartDate = profile.Ausbildungsstart;
                    }
                    else if (kalenderwoche.WeekEndDate.CompareTo(profile.Ausbildungsend) > 0)
                    {
                        kalenderwoche.WeekEndDate = profile.Ausbildungsend;
                    }

                    if (tmpAusbildungsstart.CompareTo(yearEnd) >= 0)
                    {
                        year++;
                        yearEnd = tmpAusbildungsstart.AddYears(1);
                    }

                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);

                        page.Header().Background("#44d62c").Padding(10.0f).Row(row =>
                        {
                            row.RelativeItem()
                                .AlignLeft()
                                .Column(column =>
                                {
                                    column.Item().Text(text =>
                                    {
                                        text.Span("Ausbildungsnachweis Nr.")
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");

                                        text.Span(" ")
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");

                                        text.CurrentPageNumber()
                                            .SemiBold()
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");
                                    });

                                    column.Item().Text(text =>
                                    {
                                        text.Span("Ausbildungswoche vom")
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");

                                        text.Span(" ")
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");

                                        text.Span(kalenderwoche.StartDateAsString())
                                            .SemiBold()
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");

                                        text.Span(" ")
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");

                                        text.Span("bis")
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");

                                        text.Span(" ")
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");

                                        text.Span(kalenderwoche.EndDateAsString())
                                            .SemiBold()
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");
                                    });

                                    column.Item().Text(text =>
                                    {
                                        text.Span("Ausbildungsjahr:")
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");

                                        text.Span(" ")
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");

                                        text.Span(year.ToString())
                                            .SemiBold()
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");

                                    });
                                });

                            row.RelativeItem()
                                .AlignRight()
                                .Column(column =>
                                {
                                    column.Item().Text(text =>
                                    {
                                        text.Span("Name:")
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");

                                        text.Span(" ")
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");

                                        text.Span(profile.Name)
                                            .SemiBold()
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");
                                    });

                                    column.Item().Text(text =>
                                    {
                                        text.Span("Ausbildungsabteilung:")
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");

                                        text.Span(" ")
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");

                                        text.Span(profile.Ausbildungsabteilung)
                                            .SemiBold()
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");
                                    });
                                });
                        });

                        page.Content().Background("#F5F5F5").Row(row =>
                        {
                            row.RelativeItem()
                              .Column(column =>
                              {
                                  column.Item().Row(row =>
                                  {
                                      row.RelativeItem().Column(column =>
                                      {
                                          column.Item()
                                              .Background(Colors.Grey.Lighten2)
                                              .Padding(10.0f)
                                              .Text(text =>
                                              {
                                                  text.Span("Betriebliche Tätigkeiten")
                                                    .FontFamily(fontFamily)
                                                    .FontColor("#212529");
                                              });

                                          List<TaskDto> taskList = profile.TaskList.FindAll(it => it.Date.Match(kalenderwoche));

                                          taskList.RemoveAll(it => it.IsSchool);

                                          column.Item().PaddingTop(10);

                                          taskList.ForEach(task =>
                                          {
                                              column.Item()
                                                  .PaddingLeft(20)
                                                  .Text(text =>
                                                  {
                                                      text.Span($"- {task.Desc}")
                                                        .FontFamily(fontFamily)
                                                        .FontColor("#212529");
                                                  });
                                          });
                                      });
                                  });

                                  column.Item().ExtendVertical().AlignMiddle().Row(row =>
                                  {
                                      row.RelativeItem().Column(column =>
                                      {
                                          column.Item()
                                              .Background(Colors.Grey.Lighten2)
                                              .Padding(10.0f)
                                              .Text(text =>
                                              {
                                                  text.Span("Berufsschule (Unterrichtsthemen)")
                                                    .FontFamily(fontFamily)
                                                    .FontColor("#212529");
                                              });

                                          List<TaskDto> taskList = profile.TaskList.FindAll(it => it.Date.Match(kalenderwoche));

                                          taskList.RemoveAll(it => !it.IsSchool);

                                          column.Item().PaddingTop(10);

                                          taskList.ForEach(task =>
                                          {
                                              column.Item()
                                                  .PaddingLeft(20)
                                                  .Text(text =>
                                                  {
                                                      text.Span($"- {task.Desc}")
                                                        .FontFamily(fontFamily)
                                                        .FontColor("#212529");
                                                  });
                                          });
                                      });
                                  });
                              });
                        });

                        page.Footer().Column(column =>
                        {
                            column.Item().Height(60).Row(row =>
                            {
                                row.RelativeItem().Background(Colors.Grey.Lighten2).Column(column =>
                                {
                                    column.Item()
                                        .Height(60)
                                        .BorderBottom(1)
                                        .BorderRight(1)
                                        .BorderLeft(1)
                                        .BorderColor("#FFFFFF");
                                });

                                row.RelativeItem().Background(Colors.Grey.Lighten2).Column(column =>
                                {
                                    column.Item()
                                        .Height(60)
                                        .BorderBottom(1)
                                        .BorderRight(1)
                                        .BorderLeft(1)
                                        .BorderColor("#FFFFFF");
                                });

                                row.RelativeItem().Background(Colors.Grey.Lighten2).Column(column =>
                                {
                                    column.Item()
                                        .Height(60)
                                        .BorderBottom(1)
                                        .BorderRight(1)
                                        .BorderLeft(1)
                                        .BorderColor("#FFFFFF");
                                });

                                row.RelativeItem().Background(Colors.Grey.Lighten2).Column(column =>
                                {
                                    column.Item()
                                        .Height(60)
                                        .BorderBottom(1)
                                        .BorderLeft(1)
                                        .BorderColor("#FFFFFF");
                                });
                            });

                            column.Item().Height(60).Row(row =>
                            {
                                row.RelativeItem().Background("#44d22c").Column(column =>
                                {
                                    column.Item()
                                        .Height(60)
                                        .BorderTop(1)
                                        .BorderRight(1)
                                        .BorderLeft(1)
                                        .BorderColor("#FFFFFF")
                                        .AlignMiddle()
                                        .Text(text =>
                                        {
                                            text.AlignCenter();
                                            text.Span("Auszubildende/r Unterschrift und Datum")
                                                .FontFamily(fontFamily)
                                                .FontColor("#F5F5F5");
                                        });
                                });

                                row.RelativeItem().Background("#44d22c").Column(column =>
                                {
                                    column.Item()
                                        .Height(60)
                                        .BorderTop(1)
                                        .BorderRight(1)
                                        .BorderLeft(1)
                                        .BorderColor("#FFFFFF")
                                        .AlignMiddle()
                                        .Text(text =>
                                        {
                                            text.AlignCenter();
                                            text.Span("Ausbildender bzw. Ausbilder Unterschrift und Datum")
                                                .FontFamily(fontFamily)
                                                .FontColor("#F5F5F5");
                                        });
                                });

                                row.RelativeItem().Background("#44d22c").Column(column =>
                                {
                                    column.Item()
                                        .Height(60)
                                        .BorderTop(1)
                                        .BorderRight(1)
                                        .BorderLeft(1)
                                        .BorderColor("#FFFFFF")
                                        .AlignMiddle()
                                        .Text(text =>
                                        {
                                            text.AlignCenter();
                                            text.Span("Gesetzliche/r Vertreter Unterschrift und Datum")
                                                .FontFamily(fontFamily)
                                                .FontColor("#F5F5F5");
                                        });
                                });

                                row.RelativeItem().Background("#44d22c").Column(column =>
                                {
                                    column.Item()
                                        .Height(60)
                                        .BorderTop(1)
                                        .BorderLeft(1)
                                        .BorderColor("#FFFFFF")
                                        .AlignMiddle()
                                        .Text(text =>
                                        {
                                            text.AlignCenter();
                                            text.Span("Bemerkungen")
                                                .FontFamily(fontFamily)
                                                .FontColor("#F5F5F5");
                                        });
                                });
                            });
                        });
                    });

                    tmpAusbildungsstart = tmpAusbildungsstart.AddDays(7);
                }
            }).GeneratePdf(path);
        }
    }
}