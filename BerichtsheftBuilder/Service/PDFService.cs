using BerichtsheftBuilder.Dto;
using BerichtsheftBuilder.service;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using System;
using System.Collections.Generic;

namespace BerichtsheftBuilder.Service
{
    public class PDFService
    {
        public void generate(string path, string name, string abteilung, DateTime begin, DateTime end, List<TaskDto> tasks, string fontFamily = "CMU Sans Serif")
        {
            Document.Create(container =>
            {
                DateTime tmpAusbildungsstart = begin;
                int year = 1;
                DateTime yearEnd = tmpAusbildungsstart.AddYears(1);
                while (tmpAusbildungsstart.CompareTo(end) <= 0)
                {
                    DateDto kalenderwoche = DateDto.GetCalendarWeek(tmpAusbildungsstart);

                    if (kalenderwoche.WeekStartDate.CompareTo(begin) < 0)
                    {
                        kalenderwoche.WeekStartDate = begin;
                    }
                    else if (kalenderwoche.WeekEndDate.CompareTo(end) > 0)
                    {
                        kalenderwoche.WeekEndDate = end;
                    }

                    if (tmpAusbildungsstart.CompareTo(yearEnd) >= 0)
                    {
                        year++;
                        yearEnd = tmpAusbildungsstart.AddYears(1);
                    }

                    var workTasks = tasks.FindAll(it => it.Date.Match(kalenderwoche) && !it.IsSchool);
                    var schoolTasks = tasks.FindAll(it => it.Date.Match(kalenderwoche) && it.IsSchool);

                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);

                        // header
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

                                        text.Span(name)
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

                                        text.Span(abteilung)
                                            .SemiBold()
                                            .FontFamily(fontFamily)
                                            .FontColor("#F5F5F5");
                                    });
                                });
                        });

                        // main page
                        page.Content().Extend().Layers(layer =>
                        {
                            layer.PrimaryLayer().Row(row =>
                            {
                                row.RelativeItem(0.75f).Background("#F5F5F5");
                                row.RelativeItem(0.25f).Background(Colors.Grey.Lighten3);
                            });

                            layer.Layer().Row(row =>
                            {
                                row.RelativeItem().Column(column =>
                                {
                                    column.Item().AlignTop().Column(column =>
                                    {
                                        column.Item().Row(row =>
                                        {
                                            row.RelativeItem(0.75f).Column(column =>
                                            {
                                                column.Item().Background(Colors.Grey.Lighten2).PaddingVertical(10).Row(row =>
                                                {
                                                    row.AutoItem().PaddingLeft(5).Text(text =>
                                                    {
                                                        text.Span($"Betriebliche Tätigkeiten").FontFamily(fontFamily).FontColor("#212529");
                                                    });
                                                });
                                            });

                                            row.RelativeItem(0.25f).Column(column =>
                                            {
                                                column.Item().Background(Colors.Grey.Lighten2).PaddingVertical(10).Row(row =>
                                                {
                                                    row.AutoItem().PaddingLeft(1).Text(text =>
                                                    {
                                                        text.Span($"Stunden").FontFamily(fontFamily).FontColor("#212529");
                                                    });
                                                });
                                            });
                                        });

                                        workTasks.ForEach(task =>
                                        {
                                            column.Item().Row(row =>
                                            {
                                                row.RelativeItem(0.75f).Column(column =>
                                                {
                                                    column.Item().PaddingLeft(5).Row(row =>
                                                    {
                                                        row.Spacing(5);

                                                        row.AutoItem().Text(text =>
                                                        {
                                                            text.Span($"•")
                                                                .FontFamily(fontFamily)
                                                                .FontColor(Colors.Grey.Lighten1)
                                                                .FontSize(11);
                                                        });

                                                        row.RelativeItem().Text(text =>
                                                        {
                                                            text.Span($"{task.Desc}")
                                                                .FontFamily(fontFamily)
                                                                .FontColor("#212529")
                                                                .FontSize(12);
                                                        });
                                                    });
                                                });

                                                row.RelativeItem(0.25f).Column(column =>
                                                {
                                                    column.Item().Row(row =>
                                                    {
                                                        row.AutoItem().PaddingLeft(1).Text(text =>
                                                        {
                                                            text.Span(task.formattedDuration).FontFamily(fontFamily).FontColor("#212529");
                                                        });
                                                    });
                                                });
                                            });
                                        });
                                    });

                                    column.Item().ExtendVertical().AlignMiddle().Column(column =>
                                    {
                                        column.Item().Row(row =>
                                        {
                                            row.RelativeItem(0.75f).Column(column =>
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
                                            });

                                            row.RelativeItem(0.25f).Column(column =>
                                            {
                                                column.Item()
                                                   .Background(Colors.Grey.Lighten2)
                                                   .Padding(10.0f)
                                                   .Text(text =>
                                                   {
                                                       text.Span("Stunden")
                                                         .FontFamily(fontFamily)
                                                         .FontColor("#212529");
                                                   });
                                            });
                                        });

                                        schoolTasks.ForEach(task =>
                                        {
                                            column.Item().Row(row =>
                                            {
                                                row.RelativeItem(0.75f).Column(column =>
                                                {
                                                    column.Item().PaddingLeft(5).Row(row =>
                                                    {
                                                        row.Spacing(5);

                                                        row.AutoItem().Text(text =>
                                                        {
                                                            text.Span($"•")
                                                                .FontFamily(fontFamily)
                                                                .FontColor(Colors.Grey.Lighten1)
                                                                .FontSize(11);
                                                        });

                                                        row.RelativeItem().Text(text =>
                                                        {
                                                            text.Span($"{task.Desc}")
                                                                .FontFamily(fontFamily)
                                                                .FontColor("#212529")
                                                                .FontSize(12);
                                                        });
                                                    });
                                                });

                                                row.RelativeItem(0.25f).Column(column =>
                                                {
                                                    column.Item().Row(row =>
                                                    {
                                                        row.Spacing(5);
                                                        row.AutoItem().Text(text =>
                                                        {
                                                            text.Span(task.formattedDuration).FontFamily(fontFamily).FontColor("#212529");
                                                        });
                                                    });
                                                });
                                            });
                                        });
                                    });
                                });
                            });
                        });

                        // footer
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
                                        .Padding(10)
                                        .ScaleToFit()
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
                                        .Padding(10)
                                        .ScaleToFit()
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
                                        .Padding(10)
                                        .ScaleToFit()
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
                                        .Padding(10)
                                        .ScaleToFit()
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