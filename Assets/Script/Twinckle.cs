using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twinckle: ISong
{
    private List<Notes> leftHand;
    private List<Notes> rightHand;
    public string SongName => "Twinkle Twinkle Little Star";
    public Twinckle()
    {
        leftHand = new List<Notes>();
        rightHand = new List<Notes>();

        rightHand.Add(new Notes(1.0f, 4.0f, "C3"));
        rightHand.Add(new Notes(5.0f, 8.0f, "C3"));
        rightHand.Add(new Notes(9.0f, 12.0f, "G3"));
        rightHand.Add(new Notes(13.0f, 16.0f, "G3"));
        rightHand.Add(new Notes(17.0f, 20.0f, "A4"));
        rightHand.Add(new Notes(21.0f, 24.0f, "A4"));
        rightHand.Add(new Notes(25.0f, 32.0f, "G3"));

        rightHand.Add(new Notes(33.0f, 36.0f, "F3"));
        rightHand.Add(new Notes(37.0f, 40.0f, "F3"));
        rightHand.Add(new Notes(41.0f, 44.0f, "E3"));
        rightHand.Add(new Notes(45.0f, 48.0f, "E3"));
        rightHand.Add(new Notes(49.0f, 52.0f, "D3"));
        rightHand.Add(new Notes(53.0f, 56.0f, "D3"));
        rightHand.Add(new Notes(57.0f, 64.0f, "C3"));

        rightHand.Add(new Notes(65.0f, 68.0f, "G3"));
        rightHand.Add(new Notes(69.0f, 72.0f, "G3"));
        rightHand.Add(new Notes(73.0f, 76.0f, "F3"));
        rightHand.Add(new Notes(77.0f, 80.0f, "F3"));
        rightHand.Add(new Notes(81.0f, 84.0f, "E3"));
        rightHand.Add(new Notes(85.0f, 88.0f, "E3"));
        rightHand.Add(new Notes(89.0f, 96.0f, "D3"));

        rightHand.Add(new Notes(97.0f, 100.0f, "G3"));
        rightHand.Add(new Notes(101.0f, 104.0f, "G3"));
        rightHand.Add(new Notes(105.0f, 108.0f, "F3"));
        rightHand.Add(new Notes(109.0f, 112.0f, "F3"));
        rightHand.Add(new Notes(113.0f, 116.0f, "E3"));
        rightHand.Add(new Notes(117.0f, 120.0f, "E3"));
        rightHand.Add(new Notes(121.0f, 128.0f, "D3"));

        rightHand.Add(new Notes(129.0f, 132.0f, "C3"));
        rightHand.Add(new Notes(133.0f, 136.0f, "C3"));
        rightHand.Add(new Notes(137.0f, 140.0f, "G3"));
        rightHand.Add(new Notes(141.0f, 144.0f, "G3"));
        rightHand.Add(new Notes(145.0f, 148.0f, "A4"));
        rightHand.Add(new Notes(149.0f, 152.0f, "A4"));
        rightHand.Add(new Notes(153.0f, 160.0f, "G3"));

        rightHand.Add(new Notes(161.0f, 164.0f, "F3"));
        rightHand.Add(new Notes(165.0f, 168.0f, "F3"));
        rightHand.Add(new Notes(169.0f, 172.0f, "E3"));
        rightHand.Add(new Notes(173.0f, 176.0f, "E3"));
        rightHand.Add(new Notes(177.0f, 180.0f, "D3"));
        rightHand.Add(new Notes(181.0f, 184.0f, "D3"));
        rightHand.Add(new Notes(185.0f, 192.0f, "C3"));

        leftHand.Add(new Notes(1.0f, 4.0f, "E2"));
        leftHand.Add(new Notes(5.0f, 8.0f, "E2"));
        leftHand.Add(new Notes(9.0f, 12.0f, "E2"));
        leftHand.Add(new Notes(13.0f, 16.0f, "E2"));
        leftHand.Add(new Notes(17.0f, 20.0f, "F2"));
        leftHand.Add(new Notes(21.0f, 24.0f, "F2"));
        leftHand.Add(new Notes(25.0f, 32.0f, "E2"));

        leftHand.Add(new Notes(33.0f, 36.0f, "D2"));
        leftHand.Add(new Notes(37.0f, 40.0f, "D2"));
        leftHand.Add(new Notes(41.0f, 44.0f, "C2"));
        leftHand.Add(new Notes(45.0f, 48.0f, "C2"));
        leftHand.Add(new Notes(49.0f, 52.0f, "B2"));
        leftHand.Add(new Notes(53.0f, 56.0f, "B2"));
        leftHand.Add(new Notes(57.0f, 64.0f, "C2"));

        leftHand.Add(new Notes(65.0f, 68.0f, "E2"));
        leftHand.Add(new Notes(69.0f, 72.0f, "E2"));
        leftHand.Add(new Notes(73.0f, 76.0f, "D2"));
        leftHand.Add(new Notes(77.0f, 80.0f, "D2"));
        leftHand.Add(new Notes(81.0f, 84.0f, "C2"));
        leftHand.Add(new Notes(85.0f, 88.0f, "C2"));
        leftHand.Add(new Notes(89.0f, 96.0f, "B2"));

        leftHand.Add(new Notes(97.0f, 100.0f, "E2"));
        leftHand.Add(new Notes(101.0f, 104.0f, "E2"));
        leftHand.Add(new Notes(105.0f, 108.0f, "D2"));
        leftHand.Add(new Notes(109.0f, 112.0f, "D2"));
        leftHand.Add(new Notes(113.0f, 116.0f, "C2"));
        leftHand.Add(new Notes(117.0f, 120.0f, "C2"));
        leftHand.Add(new Notes(121.0f, 128.0f, "G1"));

        leftHand.Add(new Notes(129.0f, 132.0f, "E2"));
        leftHand.Add(new Notes(133.0f, 136.0f, "E2"));
        leftHand.Add(new Notes(137.0f, 140.0f, "E2"));
        leftHand.Add(new Notes(141.0f, 144.0f, "E2"));
        leftHand.Add(new Notes(145.0f, 146.0f, "F2"));
        leftHand.Add(new Notes(147.0f, 148.0f, "G2"));
        leftHand.Add(new Notes(149.0f, 150.0f, "A3"));
        leftHand.Add(new Notes(151.0f, 152.0f, "B3"));
        leftHand.Add(new Notes(153.0f, 160.0f, "C3"));

        leftHand.Add(new Notes(161.0f, 164.0f, "D2"));
        leftHand.Add(new Notes(165.0f, 168.0f, "A3"));
        leftHand.Add(new Notes(169.0f, 172.0f, "G2"));
        leftHand.Add(new Notes(173.0f, 176.0f, "C2"));
        leftHand.Add(new Notes(177.0f, 180.0f, "G2"));
        leftHand.Add(new Notes(181.0f, 184.0f, "G1"));
        leftHand.Add(new Notes(185.0f, 192.0f, "C2"));








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
