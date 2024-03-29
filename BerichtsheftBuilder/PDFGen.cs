using QuestPDF.Fluent;
using QuestPDF.Helpers;
using System;
using System.Collections.Generic;
using static BerichtsheftBuilder.DateUtils;

namespace BerichtsheftBuilder
{
    public static class PDFGen
    {
        public static void generate(string path, ProfileStorage profileStorage)
        {
            Document.Create(container =>
            {
                DateTime tmpAusbildungsstart = profileStorage.Ausbildungsstart;
                int year = 1;
                DateTime yearEnd = tmpAusbildungsstart.AddYears(1);
                while (tmpAusbildungsstart.CompareTo(profileStorage.Ausbildungsend) <= 0)
                {
                    DateUtils.CalendarWeek kalenderwoche = DateUtils.GetCalendarWeek(tmpAusbildungsstart);

                    if(kalenderwoche.WeekStartDate.CompareTo(profileStorage.Ausbildungsstart) < 0)
                    {
                        kalenderwoche.WeekStartDate = profileStorage.Ausbildungsstart;
                    }
                    else if(kalenderwoche.WeekEndDate.CompareTo(profileStorage.Ausbildungsend) > 0)
                    {
                        kalenderwoche.WeekEndDate = profileStorage.Ausbildungsend;
                    }

                    if(tmpAusbildungsstart.CompareTo(yearEnd) >= 0)
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
                                            .FontColor("#F5F5F5");

                                        text.Span(" ")
                                            .FontColor("#F5F5F5");

                                        text.CurrentPageNumber()
                                            .SemiBold()
                                            .FontColor("#F5F5F5");
                                    });

                                    column.Item().Text(text =>
                                    {
                                        text.Span("Ausbildungswoche vom")
                                            .FontColor("#F5F5F5");

                                        text.Span(" ")
                                            .FontColor("#F5F5F5");

                                        text.Span(kalenderwoche.StartDateAsString())
                                            .SemiBold()
                                            .FontColor("#F5F5F5");

                                        text.Span(" ")
                                            .FontColor("#F5F5F5");

                                        text.Span("bis")
                                            .FontColor("#F5F5F5");

                                        text.Span(" ")
                                            .FontColor("#F5F5F5");

                                        text.Span(kalenderwoche.EndDateAsString())
                                            .SemiBold()
                                            .FontColor("#F5F5F5");

                                    });

                                    column.Item().Text(text =>
                                    {
                                        text.Span("Ausbildungsjahr:")
                                            .FontColor("#F5F5F5");

                                        text.Span(" ")
                                            .FontColor("#F5F5F5");

                                        text.Span(year.ToString())
                                            .SemiBold()
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
                                            .FontColor("#F5F5F5");

                                        text.Span(" ")
                                            .FontColor("#F5F5F5");

                                        text.Span(profileStorage.Name)
                                            .SemiBold()
                                            .FontColor("#F5F5F5");
                                    });

                                    column.Item().Text(text =>
                                    {
                                        text.Span("Ausbildungsabteilung:")
                                            .FontColor("#F5F5F5");

                                        text.Span(" ")
                                            .FontColor("#F5F5F5");

                                        text.Span(profileStorage.Ausbildungsabteilung)
                                            .SemiBold()
                                            .FontColor("#F5F5F5");
                                    });
                                });
                        });

                        page.Content().Background("#F5F5F5").Row(row =>
                        {
                            row.RelativeItem(12.0f)
                                .ExtendVertical()
                                .Column(column =>
                                {
                                    column.Item()
                                        .Padding(10.0f)
                                        .Text(text =>
                                        {
                                            text.Span("Betriebliche Tätigkeiten")
                                                .FontColor("#212529");
                                        });

                                    List<dto.TaskDTO> taskList = profileStorage.TaskList.FindAll(it => it.CalendarWeek.Match(kalenderwoche));

                                    taskList.ForEach(task => {
                                        column.Item()
                                            .PaddingLeft(20)
                                            .Text(text =>
                                            {
                                                text.Span($"- {task.Job}")
                                                    .FontColor("#212529");
                                            });
                                    });

                                    column.Item()
                                        .Padding(10.0f)
                                        .Text(text =>
                                        {
                                            text.Span("Berufsschule (Unterrichtsthemen)")
                                                .FontColor("#212529");
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
