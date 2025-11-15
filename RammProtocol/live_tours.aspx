<%@ Page Title="" Language="C#" MasterPageFile="~/RammProtocol.Master" AutoEventWireup="true" CodeBehind="live_tours.aspx.cs" Inherits="RammProtocol.live_tours" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>Tours</h1>
        <br />
        <hr />

        <div class="tour-header">
            <p>Club Tour</p>
        </div>
        <div class="tour-container">
            <div class="tour-body">
                <div class="tour-img">
                    <img src="Assets/Imgs/Tours/club-tour.jpg" alt="Club Tour" />
                </div>
                <div class="tour-details">
                    <div class="tour-info">
                        <span>Period:</span>
                        <label>Mar 24, 1994 - May 27, 1995</label>
                    </div>
                    <hr />
                    <div class="tour-info">
                        <span>Number of concerts:</span>
                        <label>36</label>
                    </div>
                </div>

            </div>
            <div class="tour-segment-list" style="margin-top: 50px;">

                <h2>Tour Segments</h2>
                <br />
                <div class="segment-row">
                    <a href="#" class="segment-title">Club Tour 1994</a>
                    <span class="segment-date">Mar 24, 1994 - Dec 31, 1994</span>
                    <span class="segment-count">30 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Club Tour 1995</a>
                    <span class="segment-date">Jan 6, 1995 - May 27, 1995</span>
                    <span class="segment-count">6 concerts</span>
                </div>

            </div>
        </div>


        <div class="tour-header">
            <p>Herzeleid Tour</p>
        </div>
        <div class="tour-container">
            <div class="tour-body">
                <div class="tour-img">
                    <img src="Assets/Imgs/Tours/herzeleid-tour.jpg" />
                </div>
                <div class="tour-details">
                    <div class="tour-info">
                        <span>Period:</span>
                        <label>Aug 8, 1995 - Dec 14, 1996 </label>
                    </div>
                    <hr />
                    <div class="tour-info">
                        <span>Number of concerts:</span>
                        <label>113</label>
                    </div>
                </div>

            </div>
            <div class="tour-segment-list" style="margin-top: 50px;">

                <h2>Tour Segments</h2>
                <br />
                <div class="segment-row">
                    <a href="#" class="segment-title">Herzeleid Tour 1995</a>
                    <span class="segment-date">Aug 8, 1995 - Dec 22, 1995</span>
                    <span class="segment-count">45 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Summer Leg</a>
                    <span class="segment-date">Aug 8, 1995 - Sep 1, 1995</span>
                    <span class="segment-count">7 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Project Pitchfork "αΩ" Tour</a>
                    <span class="segment-date">Oct 14, 1995 - Oct 31, 1995</span>
                    <span class="segment-count">15 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">November Leg</a>
                    <span class="segment-date">Nov 3, 1995 - Nov 4, 1995</span>
                    <span class="segment-count">2 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Clawfinger Tour</a>
                    <span class="segment-date">Nov 27, 1995 - Nov 29, 1995</span>
                    <span class="segment-count">2 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">December Leg</a>
                    <span class="segment-date">Dec 2, 1995 - Dec 22, 1995</span>
                    <span class="segment-count">17 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Herzeleid Tour 1996</a>
                    <span class="segment-date">Jan 19, 1996 - Dec 14, 1996</span>
                    <span class="segment-count">68 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Clawfinger Tour</a>
                    <span class="segment-date">Jan 19, 1996 - Jan 22, 1996</span>
                    <span class="segment-count">3 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Ramones "¡Adios Amigos!" Tour</a>
                    <span class="segment-date">Jan 23, 1996 - Jan 30, 1996</span>
                    <span class="segment-count">6 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Winter Leg</a>
                    <span class="segment-date">Jan 25, 1996 - Mar 3, 1996</span>
                    <span class="segment-count">16 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Spring Leg</a>
                    <span class="segment-date">May 29, 1996 - Jun 15, 1996</span>
                    <span class="segment-count">16 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Summer Leg</a>
                    <span class="segment-date">Jun 21, 1996 - Aug 18, 1996</span>
                    <span class="segment-count">9 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Autumn Leg</a>
                    <span class="segment-date">Sep 27, 1996 - Oct 12, 1996</span>
                    <span class="segment-count">14 concerts</span>
                </div>

            </div>
        </div>


        <div class="tour-header">
            <p>Sehnsucht Tour</p>
        </div>
        <div class="tour-container">
            <div class="tour-body">
                <div class="tour-img">
                    <img src="Assets/Imgs/Tours/sehnsucht-tour.jpg" alt="Sehnsucht tour" />
                </div>
                <div class="tour-details">
                    <div class="tour-info">
                        <span>Period:</span>
                        <label>Apr 9, 1997 - Feb 10, 2001</label>
                    </div>
                    <hr />
                    <div class="tour-info">
                        <span>Number of concerts:</span>
                        <label>169</label>
                    </div>
                </div>

            </div>
            <div class="tour-segment-list" style="margin-top: 50px;">

                <h2>Tour Segments</h2>
                <br />
                <div class="segment-row">
                    <a href="#" class="segment-title">Sehnsucht Tour 1997</a>
                    <span class="segment-date">Apr 9, 1997 - Dec 14, 1997</span>
                    <span class="segment-count">78 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Spring Leg</a>
                    <span class="segment-date">Apr 9, 1997 - May 25, 1997</span>
                    <span class="segment-count">19 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Summer Leg</a>
                    <span class="segment-date">Jun 12, 1997 - Sep 6, 1997</span>
                    <span class="segment-count">15 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Autumn Leg</a>
                    <span class="segment-date">Sep 26, 1997 - Oct 23, 1997</span>
                    <span class="segment-count">23 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">November Leg</a>
                    <span class="segment-date">Nov 15, 1997 - Nov 29, 1997</span>
                    <span class="segment-count">11 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">KMFDM "Symbols" Tour</a>
                    <span class="segment-date">Dec 5, 1997 - Dec 14, 1997</span>
                    <span class="segment-count">8 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Sehnsucht Tour 1998</a>
                    <span class="segment-date">Apr 26, 1998 - Nov 12, 1998</span>
                    <span class="segment-count">56 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">USA Spring Leg</a>
                    <span class="segment-date">Apr 26, 1998 - May 6, 1998</span>
                    <span class="segment-count">5 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Europe Spring Leg</a>
                    <span class="segment-date">May 13, 1998 - May 20, 1998</span>
                    <span class="segment-count">8 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Festivals & Open Air Leg</a>
                    <span class="segment-date">May 29, 1998 - Sep 12, 1998</span>
                    <span class="segment-count">14 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Family Values Tour 1998</a>
                    <span class="segment-date">Sep 22, 1998 - Oct 31, 1998</span>
                    <span class="segment-count">28 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Sehnsucht Tour 1999</a>
                    <span class="segment-date">Apr 10, 1999 - Jun 23, 1999</span>
                    <span class="segment-count">22 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">KISS "Psycho Circus" Tour</a>
                    <span class="segment-date">Apr 10, 1999 - Apr 24, 1999</span>
                    <span class="segment-count">4 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">North American Leg</a>
                    <span class="segment-date">Jun 1, 1999 - Jun 23, 1999</span>
                    <span class="segment-count">17 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Sehnsucht Tour 2000</a>
                    <span class="segment-date">Apr 16, 2000 - Jul 30, 2000</span>
                    <span class="segment-count">2 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Sehnsucht Tour 2001</a>
                    <span class="segment-date">Jan 18, 2001 - Feb 10, 2001</span>
                    <span class="segment-count">11 concerts</span>
                </div>

            </div>
        </div>



        <div class="tour-header">
            <p>Mutter Tour</p>
        </div>
        <div class="tour-container">
            <div class="tour-body">
                <div class="tour-img">
                    <img src="Assets/Imgs/Tours/mutter-tour.jpg" alt="Club Tour" />
                </div>
                <div class="tour-details">
                    <div class="tour-info">
                        <span>Period:</span>
                        <label>May 1, 2001 - Jul 13, 2002</label>
                    </div>
                    <hr />
                    <div class="tour-info">
                        <span>Number of concerts:</span>
                        <label>116</label>
                    </div>
                </div>

            </div>
            <div class="tour-segment-list" style="margin-top: 50px;">

                <h2>Tour Segments</h2>
                <br />
                <div class="segment-row">
                    <a href="#" class="segment-title">Mutter Tour 2001</a>
                    <span class="segment-date">May 1, 2001 - Dec 15, 2001</span>
                    <span class="segment-count">99 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Spring/Summer European Leg</a>
                    <span class="segment-date">May 1, 2001 - Jun 16, 2001</span>
                    <span class="segment-count">23 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">North American Leg</a>
                    <span class="segment-date">Jun 29, 2001 - Aug 6, 2001</span>
                    <span class="segment-count">30 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Pledge of Allegiance Tour</a>
                    <span class="segment-date">Sep 21, 2001 - Oct 24, 2001</span>
                    <span class="segment-count">24 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Winter European Leg</a>
                    <span class="segment-date">Nov 8, 2001 - Dec 15, 2001</span>
                    <span class="segment-count">22 concerts</span>
                </div>

                <div class="segment-row">
                    <a href="#" class="segment-title">Mutter Tour 2002</a>
                    <span class="segment-date">May 14, 2002 - Jul 13, 2002</span>
                    <span class="segment-count">17 concerts</span>
                </div>

            </div>
            <div class="tour-header">
                <p>Reise, Reise Tour</p>
            </div>
            <div class="tour-container">
                <div class="tour-body">
                    <div class="tour-img">
                        <img src="Assets/Imgs/Tours/reise-reise-tour.jpg" alt="Reise Reise Tour" />
                    </div>
                    <div class="tour-details">
                        <div class="tour-info">
                            <span>Period:</span>
                            <label>Sep 30, 2004 - Jul 30, 2005 </label>
                        </div>
                        <hr />
                        <div class="tour-info">
                            <span>Number of concerts:</span>
                            <label>73</label>
                        </div>
                    </div>

                </div>
                <div class="tour-segment-list" style="margin-top: 50px;">

                    <h2>Tour Segments</h2>
                    <br />
                    <div class="segment-row">
                        <a href="#" class="segment-title">Reise, Reise Tour 2004</a>
                        <span class="segment-date">Sep 30, 2004 - Dec 18, 2004</span>
                        <span class="segment-count">31 concerts</span>
                    </div>

                    <div class="segment-row">
                        <a href="#" class="segment-title">Reise, Reise Tour 2005</a>
                        <span class="segment-date">Feb 1, 2005 - Jul 30, 2005</span>
                        <span class="segment-count">42 concerts</span>
                    </div>

                    <div class="segment-row">
                        <a href="#" class="segment-title">Winter Leg</a>
                        <span class="segment-date">Feb 1, 2005 - Feb 28, 2005</span>
                        <span class="segment-count">21 concerts</span>
                    </div>

                    <div class="segment-row">
                        <a href="#" class="segment-title">Summer Leg</a>
                        <span class="segment-date">Apr 2, 2005 - Jul 30, 2005</span>
                        <span class="segment-count">21 concerts</span>
                    </div>

                </div>
            </div>
            <div class="tour-header">
                <p>Lifad Tour</p>
            </div>
            <div class="tour-container">
                <div class="tour-body">
                    <div class="tour-img">
                        <img src="Assets/Imgs/Tours/lifad-tour.jpg" alt="Club Tour" />
                    </div>
                    <div class="tour-details">
                        <div class="tour-info">
                            <span>Period:</span>
                            <label>Oct 27, 2009 - May 31, 2011</label>
                        </div>
                        <hr />
                        <div class="tour-info">
                            <span>Number of concerts:</span>
                            <label>118</label>
                        </div>
                    </div>

                </div>
                <div class="tour-segment-list" style="margin-top: 50px;">

                    <h2>Tour Segments</h2>
                    <br />
                    <div class="segment-row">
                        <a href="#" class="segment-title">LIFAD Tour 2009</a>
                        <span class="segment-date">Oct 27, 2009 - Dec 21, 2009</span>
                        <span class="segment-count">32 concerts</span>
                    </div>

                    <div class="segment-row">
                        <a href="#" class="segment-title">LIFAD Tour 2010</a>
                        <span class="segment-date">Jan 31, 2010 - Dec 11, 2010</span>
                        <span class="segment-count">63 concerts</span>
                    </div>

                    <div class="segment-row">
                        <a href="#" class="segment-title">Winter Leg</a>
                        <span class="segment-date">Jan 31, 2010 - Mar 20, 2010</span>
                        <span class="segment-count">29 concerts</span>
                    </div>

                    <div class="segment-row">
                        <a href="#" class="segment-title">Summer Leg</a>
                        <span class="segment-date">May 21, 2010 - Jul 31, 2010</span>
                        <span class="segment-count">25 concerts</span>
                    </div>

                    <div class="segment-row">
                        <a href="#" class="segment-title">American Leg</a>
                        <span class="segment-date">Nov 25, 2010 - Dec 11, 2010</span>
                        <span class="segment-count">9 concerts</span>
                    </div>

                    <div class="segment-row">
                        <a href="#" class="segment-title">LIFAD Tour 2011</a>
                        <span class="segment-date">Jan 21, 2011 - May 31, 2011</span>
                        <span class="segment-count">23 concerts</span>
                    </div>

                    <div class="segment-row">
                        <a href="#" class="segment-title">Big Day Out 2011</a>
                        <span class="segment-date">Jan 21, 2011 - Feb 6, 2011</span>
                        <span class="segment-count">7 concerts</span>
                    </div>

                    <div class="segment-row">
                        <a href="#" class="segment-title">South African Leg</a>
                        <span class="segment-date">Feb 9, 2011 - Feb 11, 2011</span>
                        <span class="segment-count">2 concerts</span>
                    </div>

                    <div class="segment-row">
                        <a href="#" class="segment-title">North American Leg</a>
                        <span class="segment-date">May 5, 2011 - May 31, 2011</span>
                        <span class="segment-count">14 concerts</span>
                    </div>

                </div>

            </div>
            <div class="tour-header">
                <p>Made in Germany Tour</p>
            </div>
            <div class="tour-container">
                <div class="tour-body">
                    <div class="tour-img">
                        <img src="Assets/Imgs/Tours/made-in-germany-tour.jpg" alt="Made in Germany Tour" />
                    </div>
                    <div class="tour-details">
                        <div class="tour-info">
                            <span>Period:</span>
                            <label>Oct 27, 2011 - Aug 1, 2013</label>
                        </div>
                        <hr />
                        <div class="tour-info">
                            <span>Number of concerts:</span>
                            <label>104</label>
                        </div>
                    </div>

                </div>
                <div class="tour-segment-list" style="margin-top: 50px;">

                    <h2>Tour Segments</h2>
                    <br />
                    <div class="segment-row">
                        <a href="#" class="segment-title">Made In Germany Tour 2011</a>
                        <span class="segment-date">Oct 27, 2011 - Dec 15, 2011</span>
                        <span class="segment-count">29 concerts</span>
                    </div>

                    <div class="segment-row">
                        <a href="#" class="segment-title">Made In Germany Tour 2012</a>
                        <span class="segment-date">Feb 3, 2012 - May 25, 2012</span>
                        <span class="segment-count">43 concerts</span>
                    </div>

                    <div class="segment-row">
                        <a href="#" class="segment-title">European Leg</a>
                        <span class="segment-date">Feb 3, 2012 - Mar 22, 2012</span>
                        <span class="segment-count">22 concerts</span>
                    </div>

                    <div class="segment-row">
                        <a href="#" class="segment-title">North American Leg</a>
                        <span class="segment-date">Apr 20, 2012 - May 25, 2012</span>
                        <span class="segment-count">21 concerts</span>
                    </div>

                    <div class="segment-row">
                        <a href="#" class="segment-title">Made In Germany Tour 2013</a>
                        <span class="segment-date">Apr 8, 2013 - Aug 1, 2013</span>
                        <span class="segment-count">32 concerts</span>
                    </div>

                    <div class="segment-row">
                        <a href="#" class="segment-title">Indoor Leg</a>
                        <span class="segment-date">Apr 8, 2013 - Apr 30, 2013</span>
                        <span class="segment-count">10 concerts</span>
                    </div>

                    <div class="segment-row">
                        <a href="#" class="segment-title">Festivals & Open Air Leg</a>
                        <span class="segment-date">May 4, 2013 - Aug 1, 2013</span>
                        <span class="segment-count">22 concerts</span>
                    </div>

                </div>
            </div>
            <div class="tour-header">
                <p>Festivals Tour 2016/2017</p>
            </div>
            <div class="tour-container">
                <div class="tour-body">
                    <div class="tour-img">
                        <img src="Assets/Imgs/Tours/festivals-tour-2016-2017.jpg" alt="Club Tour" />
                    </div>
                    <div class="tour-details">
                        <div class="tour-info">
                            <span>Period:</span>
                            <label>Mar 24, 1994 - May 27, 1995</label>
                        </div>
                        <hr />
                        <div class="tour-info">
                            <span>Number of concerts:</span>
                            <label>36</label>
                        </div>
                    </div>

                </div>
                <div class="tour-segment-list" style="margin-top: 50px;">

                    <h2>Tour Segments</h2>
                    <br />
                    <div class="segment-row">
                        <a href="#" class="segment-title">Festivals Tour 2016</a>
                        <span class="segment-date">May 26, 2016 - Sep 10, 2016 </span>
                        <span class="segment-count">26 concerts</span>
                    </div>

                    <div class="segment-row">
                        <a href="#" class="segment-title">Festivals Tour 2017</a>
                        <span class="segment-date">May 20, 2017 - Jul 13, 2017 </span>
                        <span class="segment-count">17 concerts</span>
                    </div>

                </div>
            </div>
            <div class="tour-header">
                <p>New Year's Eve 2018</p>
            </div>
            <div class="tour-container">
                <div class="tour-body">
                    <div class="tour-img">
                        <img src="Assets/Imgs/Tours/new-years-eve-2018.jpg" alt="Club Tour" />
                    </div>
                    <div class="tour-details">
                        <div class="tour-info">
                            <span>Period:</span>
                            <label>Dec 31, 2018 - Jan 2, 2019</label>
                        </div>
                        <hr />
                        <div class="tour-info">
                            <span>Number of concerts:</span>
                            <label>2</label>
                        </div>
                    </div>

                </div>
                <div class="tour-header">
                    <p>Stadium Tour</p>
                </div>
                <div class="tour-container">
                    <div class="tour-body">
                        <div class="tour-img">
                            <img src="Assets/Imgs/Tours/stadium-tour.jpg" alt="Club Tour" />
                        </div>
                        <div class="tour-details">
                            <div class="tour-info">
                                <span>Period:</span>
                                <label>May 24, 2019 - Jul 31, 2024</label>
                            </div>
                            <hr />
                            <div class="tour-info">
                                <span>Number of concerts:</span>
                                <label>141</label>
                            </div>
                        </div>

                    </div>
                    <div class="tour-segment-list" style="margin-top: 50px;">

                        <h2>Tour Segments</h2>
                        <br />
                        <div class="segment-row">
                            <a href="#" class="segment-title">Europe Stadium Tour 2019</a>
                            <span class="segment-date">May 24, 2019 - Aug 23, 2019</span>
                            <span class="segment-count">33 concerts</span>
                        </div>

                        <div class="segment-row">
                            <a href="#" class="segment-title">Europe Stadium Tour 2022</a>
                            <span class="segment-date">May 11, 2022 - Aug 4, 2022</span>
                            . <span class="segment-count">34 concerts</span>
                        </div>

                        <div class="segment-row">
                            <a href="#" class="segment-title">North America Stadium Tour 2022</a>
                            <span class="segment-date">Aug 21, 2022 - Oct 4, 2022</span>
                            <span class="segment-count">12 concerts</span>
                        </div>

                        <div class="segment-row">
                            <a href="#" class="segment-title">Europe Stadium Tour 2023</a>
                            <span class="segment-date">May 20, 2023 - Aug 5, 2023</span>
                            <span class="segment-count">31 concerts</span>
                        </div>

                        <div class="segment-row">
                            <a href="#" class="segment-title">Europe Stadium Tour 2024</a>
                            <span class="segment-date">May 9, 2024 - Jul 31, 2024</span>
                            <span class="segment-count">31 concerts</span>
                        </div>

                    </div>
                </div>
</asp:Content>
