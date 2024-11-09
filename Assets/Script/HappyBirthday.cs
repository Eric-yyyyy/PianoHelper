using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappyBirthday : ISong
{
    private List<Notes> leftHand;
    private List<Notes> rightHand;
    public string SongName => "Happy Birthday";

    public HappyBirthday()
    {
        leftHand = new List<Notes>();
        rightHand = new List<Notes>();
        rightHand.Add(new Notes(9.0f, 11.0f, "G3"));
        rightHand.Add(new Notes(12.0f, 12.0f, "G3"));
        rightHand.Add(new Notes(13.0f, 16.0f, "G4"));
        rightHand.Add(new Notes(17.0f, 20.0f, "E4"));
        rightHand.Add(new Notes(21.0f, 24.0f, "C4"));
        rightHand.Add(new Notes(25.0f, 28.0f, "B4"));
        rightHand.Add(new Notes(29.0f, 32.0f, "A4"));

        rightHand.Add(new Notes(33.0f, 35.0f, "F4"));
        rightHand.Add(new Notes(36.0f, 36.0f, "F4"));

        rightHand.Add(new Notes(37.0f, 40.0f, "E4"));
        rightHand.Add(new Notes(41.0f, 44.0f, "C4"));
        rightHand.Add(new Notes(45.0f, 48.0f, "D4"));

        rightHand.Add(new Notes(49.0f, 56.0f, "C3"));
        rightHand.Add(new Notes(57.0f, 59.0f, "G3"));
        rightHand.Add(new Notes(60.0f, 60.0f, "G3"));
        rightHand.Add(new Notes(61.0f, 64.0f, "A4"));
        rightHand.Add(new Notes(65.0f, 68.0f, "G3"));
        rightHand.Add(new Notes(69.0f, 72.0f, "C4"));
        rightHand.Add(new Notes(73.0f, 80.0f, "B4"));

        rightHand.Add(new Notes(81.0f, 83.0f, "G3"));
        rightHand.Add(new Notes(84.0f, 84.0f, "G3"));
        rightHand.Add(new Notes(85.0f, 88.0f, "A4"));
        rightHand.Add(new Notes(89.0f, 92.0f, "G3"));
        rightHand.Add(new Notes(93.0f, 96.0f, "D4"));
        rightHand.Add(new Notes(97.0f, 104.0f, "C4"));

        rightHand.Add(new Notes(105.0f, 107.0f, "G3"));
        rightHand.Add(new Notes(108.0f, 108.0f, "G3"));

        rightHand.Add(new Notes(109.0f, 112.0f, "G4"));
        rightHand.Add(new Notes(113.0f, 116.0f, "E4"));
        rightHand.Add(new Notes(117.0f, 120.0f, "C4"));
        rightHand.Add(new Notes(121.0f, 124.0f, "B4"));
        rightHand.Add(new Notes(125.0f, 128.0f, "A4"));

        rightHand.Add(new Notes(129.0f, 131.0f, "F4"));
        rightHand.Add(new Notes(132.0f, 132.0f, "F4"));

        rightHand.Add(new Notes(133.0f, 136.0f, "E4"));
        rightHand.Add(new Notes(137.0f, 140.0f, "C4"));
        rightHand.Add(new Notes(141.0f, 144.0f, "D4"));

        rightHand.Add(new Notes(145.0f, 152.0f, "C4"));

        rightHand.Add(new Notes(153.0f, 155.0f, "G3"));
        rightHand.Add(new Notes(156.0f, 156.0f, "G3"));

        rightHand.Add(new Notes(157.0f, 160.0f, "A4"));
        rightHand.Add(new Notes(161.0f, 164.0f, "G3"));
        rightHand.Add(new Notes(165.0f, 168.0f, "C4"));
        rightHand.Add(new Notes(169.0f, 176.0f, "B4"));

        rightHand.Add(new Notes(177.0f, 179.0f, "G3"));
        rightHand.Add(new Notes(180.0f, 180.0f, "G3"));
        rightHand.Add(new Notes(181.0f, 184.0f, "A4"));
        rightHand.Add(new Notes(185.0f, 188.0f, "G3"));
        rightHand.Add(new Notes(189.0f, 192.0f, "D4"));
        rightHand.Add(new Notes(193.0f, 200.0f, "C4"));

        rightHand.Add(new Notes(201.0f, 203.0f, "G3"));
        rightHand.Add(new Notes(204.0f, 204.0f, "G3"));

        rightHand.Add(new Notes(205.0f, 208.0f, "G4"));
        rightHand.Add(new Notes(209.0f, 212.0f, "E4"));
        rightHand.Add(new Notes(213.0f, 216.0f, "C4"));
        rightHand.Add(new Notes(217.0f, 220.0f, "B4"));
        rightHand.Add(new Notes(221.0f, 224.0f, "A4"));

        rightHand.Add(new Notes(225.0f, 227.0f, "F4"));
        rightHand.Add(new Notes(228.0f, 228.0f, "F4"));

        rightHand.Add(new Notes(229.0f, 232.0f, "E4"));
        rightHand.Add(new Notes(233.0f, 236.0f, "C4"));
        rightHand.Add(new Notes(237.0f, 240.0f, "D4"));
        rightHand.Add(new Notes(241.0f, 252.0f, "C4"));

        leftHand.Add(new Notes(13.0f, 16.0f, "C2"));
        leftHand.Add(new Notes(17.0f, 20.0f, "G2"));
        leftHand.Add(new Notes(21.0f, 24.0f, "C3"));

        leftHand.Add(new Notes(25.0f, 28.0f, "F1"));
        leftHand.Add(new Notes(29.0f, 32.0f, "C2"));
        leftHand.Add(new Notes(33.0f, 36.0f, "F2"));

        leftHand.Add(new Notes(37.0f, 40.0f, "G1"));
        leftHand.Add(new Notes(41.0f, 44.0f, "D2"));
        leftHand.Add(new Notes(45.0f, 48.0f, "G2"));

        leftHand.Add(new Notes(49.0f, 52.0f, "C2"));
        leftHand.Add(new Notes(53.0f, 56.0f, "G2"));
        leftHand.Add(new Notes(57.0f, 60.0f, "C3"));
       
        leftHand.Add(new Notes(61.0f, 64.0f, "C2"));
        leftHand.Add(new Notes(65.0f, 68.0f, "G2"));
        leftHand.Add(new Notes(69.0f, 72.0f, "C3"));

        leftHand.Add(new Notes(73.0f, 76.0f, "G1"));
        leftHand.Add(new Notes(77.0f, 80.0f, "D2"));
        leftHand.Add(new Notes(81.0f, 84.0f, "G2"));

        leftHand.Add(new Notes(85.0f, 88.0f, "G1"));
        leftHand.Add(new Notes(89.0f, 92.0f, "D2"));
        leftHand.Add(new Notes(93.0f, 96.0f, "G2"));
        //third line
        leftHand.Add(new Notes(97.0f, 100.0f, "C2"));
        leftHand.Add(new Notes(101.0f, 104.0f, "G2"));
        leftHand.Add(new Notes(105.0f, 108.0f, "C3"));

        leftHand.Add(new Notes(109.0f, 112.0f, "C2"));
        leftHand.Add(new Notes(113.0f, 116.0f, "G2"));
        leftHand.Add(new Notes(117.0f, 120.0f, "C3"));

        leftHand.Add(new Notes(121.0f, 124.0f, "F1"));
        leftHand.Add(new Notes(125.0f, 128.0f, "C2"));
        leftHand.Add(new Notes(129.0f, 132.0f, "F2"));

        leftHand.Add(new Notes(133.0f, 136.0f, "G1"));
        leftHand.Add(new Notes(137.0f, 140.0f, "D2"));
        leftHand.Add(new Notes(141.0f, 144.0f, "G2"));

        leftHand.Add(new Notes(145.0f, 148.0f, "C2"));
        leftHand.Add(new Notes(149.0f, 152.0f, "G2"));
        leftHand.Add(new Notes(153.0f, 156.0f, "C3"));

        leftHand.Add(new Notes(157.0f, 160.0f, "C2"));
        leftHand.Add(new Notes(161.0f, 164.0f, "G2"));
        leftHand.Add(new Notes(165.0f, 168.0f, "C3"));

        leftHand.Add(new Notes(169.0f, 172.0f, "G1"));
        leftHand.Add(new Notes(173.0f, 176.0f, "D2"));
        leftHand.Add(new Notes(177.0f, 180.0f, "G2"));

        leftHand.Add(new Notes(181.0f, 184.0f, "G1"));
        leftHand.Add(new Notes(185.0f, 188.0f, "D2"));
        leftHand.Add(new Notes(189.0f, 192.0f, "G2"));

        // Third line
        leftHand.Add(new Notes(193.0f, 196.0f, "C2"));
        leftHand.Add(new Notes(197.0f, 200.0f, "G2"));
        leftHand.Add(new Notes(201.0f, 204.0f, "C3"));

        leftHand.Add(new Notes(205.0f, 208.0f, "C2"));
        leftHand.Add(new Notes(209.0f, 212.0f, "G2"));
        leftHand.Add(new Notes(213.0f, 216.0f, "C3"));

        leftHand.Add(new Notes(217.0f, 220.0f, "F1"));
        leftHand.Add(new Notes(221.0f, 224.0f, "C2"));
        leftHand.Add(new Notes(225.0f, 228.0f, "F2"));

        leftHand.Add(new Notes(229.0f, 232.0f, "G1"));
        leftHand.Add(new Notes(233.0f, 236.0f, "D2"));
        leftHand.Add(new Notes(237.0f, 240.0f, "G2"));

        leftHand.Add(new Notes(241.0f, 244.0f, "C2"));
        leftHand.Add(new Notes(245.0f, 248.0f, "G2"));
        leftHand.Add(new Notes(249.0f, 252.0f, "C3"));

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
