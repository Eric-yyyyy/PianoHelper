using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleCity : ISong
    
{
    private List<Notes> leftHand;
    private List<Notes> rightHand;
    public string SongName =>  "Castle in the Sky";
    
    public CastleCity()
    {
        leftHand = new List<Notes>();
        rightHand = new List<Notes>();
        //First Page
        //first 4 bars
        rightHand.Add(new Notes(13.0f, 14.0f, "A4"));
        rightHand.Add(new Notes(15.0f, 16.0f, "B4"));
        rightHand.Add(new Notes(17.0f, 22.0f, "C4"));
        rightHand.Add(new Notes(23.0f, 24.0f, "B4"));
        rightHand.Add(new Notes(25.0f, 28.0f, "C4"));
        rightHand.Add(new Notes(29.0f, 32.0f, "E4"));
        rightHand.Add(new Notes(33.0f, 44.0f, "B4"));

        rightHand.Add(new Notes(45.0f, 48.0f, "E3"));
        rightHand.Add(new Notes(49.0f, 55.0f, "A4"));
        rightHand.Add(new Notes(55.0f, 56.0f, "G3"));
        rightHand.Add(new Notes(57.0f, 60.0f, "A4"));
        rightHand.Add(new Notes(61.0f, 64.0f, "C4"));

        //second Line
        rightHand.Add(new Notes(65.0f, 76.0f, "G3"));
        rightHand.Add(new Notes(77.0f, 80.0f, "E3"));

        rightHand.Add(new Notes(81.0f, 86.0f, "F3"));
        rightHand.Add(new Notes(87.0f, 88.0f, "E3"));
        rightHand.Add(new Notes(89.0f, 90.0f, "F3"));
        rightHand.Add(new Notes(91.0f, 96.0f, "C4"));

        rightHand.Add(new Notes(97.0f, 108.0f, "E3"));
        rightHand.Add(new Notes(109.0f, 110.0f, "C4"));
        rightHand.Add(new Notes(111.0f, 112.0f, "C4"));
        rightHand.Add(new Notes(113.0f, 118.0f, "B4"));
        rightHand.Add(new Notes(119.0f, 120.0f, "Fsharp3"));
        rightHand.Add(new Notes(121.0f, 124.0f, "Fsharp3"));
        rightHand.Add(new Notes(125.0f, 128.0f, "B4"));
        rightHand.Add(new Notes(129.0f, 140.0f, "B4"));
        rightHand.Add(new Notes(141.0f, 142.0f, "A4"));
        rightHand.Add(new Notes(143.0f, 144.0f, "B4"));
        //third Line

        rightHand.Add(new Notes(145.0f, 150.0f, "C4"));
        rightHand.Add(new Notes(151.0f, 152.0f, "B4"));
        rightHand.Add(new Notes(153.0f, 156.0f, "C4"));
        rightHand.Add(new Notes(157.0f, 160.0f, "E4"));

        rightHand.Add(new Notes(161.0f, 172.0f, "B4"));
        rightHand.Add(new Notes(173.0f, 176.0f, "E3"));

        rightHand.Add(new Notes(177.0f, 182.0f, "A4"));
        rightHand.Add(new Notes(183.0f, 184.0f, "G3"));
        rightHand.Add(new Notes(185.0f, 188.0f, "A4"));
        rightHand.Add(new Notes(189.0f, 192.0f, "C4"));

        rightHand.Add(new Notes(193.0f, 200.0f, "G3"));
        rightHand.Add(new Notes(201.0f, 204.0f, "E3"));

        rightHand.Add(new Notes(205.0f, 208.0f, "F3"));
        rightHand.Add(new Notes(209.0f, 210.0f, "C4"));
        rightHand.Add(new Notes(211.0f, 216.0f, "B4"));
        rightHand.Add(new Notes(217.0f, 220.0f, "C4"));
        //fourth Line

        rightHand.Add(new Notes(221.0f, 222.0f, "D4"));
        rightHand.Add(new Notes(223.0f, 226.0f, "D4"));
        rightHand.Add(new Notes(227.0f, 228.0f, "E4"));
        rightHand.Add(new Notes(229.0f, 236.0f, "C4"));

        rightHand.Add(new Notes(237.0f, 238.0f, "C4"));
        rightHand.Add(new Notes(239.0f, 240.0f, "B4"));
        rightHand.Add(new Notes(241.0f, 244.0f, "A4"));
        rightHand.Add(new Notes(245.0f, 248.0f, "B4"));
        rightHand.Add(new Notes(249.0f, 252.0f, "Gsharp3"));

        rightHand.Add(new Notes(253.0f, 264.0f, "A4"));
        rightHand.Add(new Notes(265.0f, 266.0f, "C4"));
        rightHand.Add(new Notes(267.0f, 268.0f, "D4"));

        rightHand.Add(new Notes(269.0f, 274.0f, "E4"));
        rightHand.Add(new Notes(275.0f, 276.0f, "D4"));
        rightHand.Add(new Notes(277.0f, 280.0f, "E4"));
        rightHand.Add(new Notes(281.0f, 284.0f, "G4"));

        //fifth Line
        rightHand.Add(new Notes(285.0f, 296.0f, "D4"));
        rightHand.Add(new Notes(297.0f, 300.0f, "G3"));

        rightHand.Add(new Notes(301.0f, 306.0f, "C4"));
        rightHand.Add(new Notes(307.0f, 308.0f, "B4"));
        rightHand.Add(new Notes(309.0f, 312.0f, "C4"));
        rightHand.Add(new Notes(313.0f, 314.0f, "D4"));
        rightHand.Add(new Notes(315.0f, 316.0f, "E4"));

        rightHand.Add(new Notes(317.0f, 332.0f, "E4"));

        rightHand.Add(new Notes(333.0f, 334.0f, "A3"));
        rightHand.Add(new Notes(335.0f, 336.0f, "B3"));
        rightHand.Add(new Notes(337.0f, 340.0f, "C3"));
        rightHand.Add(new Notes(341.0f, 342.0f, "B3"));
        rightHand.Add(new Notes(343.0f, 344.0f, "C3"));
        rightHand.Add(new Notes(345.0f, 348.0f, "D3"));

        //Second Page
    }

    public List<Notes> getRightHand()
    {
        return rightHand;
    }

    public List<Notes> getLeftHand()
    {
        return leftHand;
    }
}
