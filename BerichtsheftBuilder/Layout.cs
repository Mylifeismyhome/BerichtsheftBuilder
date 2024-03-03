using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerichtsheftBuilder
{
    internal class Layout
    {
        public static string md
        {
            get
            {
                return @"<div style=""display: grid;
                            grid-template-columns: repeat(2, 1fr);
                            grid-template-rows: 1fr;
                            grid-column-gap: 0px;
                            grid-row-gap: 0px;"">
                    <div style=""text-align: left;"">
                        Ausbildungsnachweis Nr. <b>test</b>
                    </div>
                    <div style=""text-align: right;"">
                        Name: <b>Tobias Staack</b>
                    </div>
                </div>
                <div style=""display: grid;
                            grid-template-columns: repeat(2, 1fr);
                            grid-template-rows: 1fr;
                            grid-column-gap: 0px;
                            grid-row-gap: 0px;"">
                    <div style=""text-align: left;"">
                        Ausbildungswoche vom <b>01.08.2023</b>
                        bis <b>20.10.2023</b>
                    </div>
                    <div style=""text-align: right;"">
                        Ausbildungsabteilung: <b>Anwendungsentwicklung</b>
                    </div>
                </div>
                <div style=""display: grid;
                            grid-template-columns: repeat(1, 1fr);
                            grid-template-rows: 1fr;
                            grid-column-gap: 0px;
                            grid-row-gap: 0px;"">
                    <div style=""text-align: left;"">
                        Ausbildungsjahr: <b>1</b>
                    </div>
                </div>
                <br>
                <div style=""border: 3px solid white;padding: 5px"">
                    <b>Betriebliche Tätigkeiten</b>
                    <br><br>
                    <ul style=""list-style-type: '- ';"">
                        <li>test</li>
                        <li>test</li>
                        <li>test</li>
                        <li>test</li>
                    </ul>
                    <hr style=""background: white""></hr>
                    <b>Berufsschule (Unterrichtsthemen)</b>
                    <br><br>
                    <ul style=""list-style-type: '- ';"">
                        <li>test</li>
                        <li>test</li>
                        <li>test</li>
                        <li>test</li>
                    </ul>
                    <hr style=""background: white""></hr>
                    <div style=""display: grid;
                                grid-template-columns: repeat(4, 1fr);
                                grid-template-rows: 1fr;
                                grid-column-gap: 0px;
                                grid-row-gap: 0px;"">
                        <div style=""text-align: center;
                                    border-right: 2px solid white;
                                    padding: 5px;"">
                            <div style=""height: 80px;"">
                            </div>
                            <hr>
                            <b>Auszubildende/r
                            Unterschrift und Datum</b>
                        </div>
                            <div style=""text-align: center;
                                        border-right: 2px solid white;
                                        padding: 5px;"">
                            <div style=""height: 80px;"">
                            </div>
                            <hr>
                            <b>Ausbildender bzw. Ausbilder
                            Unterschrift und Datum</b>
                        </div>
                            <div style=""text-align: center;
                                        border-right: 2px solid white;
                                        padding: 5px;"">
                            <div style=""height: 80px;"">
                            </div>
                            <hr>
                            <b>Gesetzliche/r Vertreter
                            Unterschrift und Datum</b>
                        </div>
                            <div style=""text-align: center;
                                        padding: 5px;"">
                            <div style=""height: 80px;"">
                            </div>
                            <hr>
                            <b>Bemerkungen</b>
                        </div>
                    </div>
                </div>";
            }
        }
    }
}
