using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleCity : ISong
    
{
    private List<Notes> leftHand;
    private List<Notes> rightHand;
    public string SongName =>  "Laputua: Castle in the Sky";
    
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

        rightHand.Add(new Notes(193.0f, 204.0f, "G3"));
        rightHand.Add(new Notes(205.0f, 208.0f, "E3"));

        rightHand.Add(new Notes(209.0f, 212.0f, "F3"));
        rightHand.Add(new Notes(213.0f, 214.0f, "C4"));
        rightHand.Add(new Notes(215.0f, 220.0f, "B4"));
        rightHand.Add(new Notes(221.0f, 224.0f, "C4"));
        //fourth Line

        rightHand.Add(new Notes(225.0f, 226.0f, "D4"));
        rightHand.Add(new Notes(227.0f, 230.0f, "D4"));
        rightHand.Add(new Notes(231.0f, 232.0f, "E4"));
        rightHand.Add(new Notes(234.0f, 240.0f, "C4"));

        rightHand.Add(new Notes(241.0f, 242.0f, "C4"));
        rightHand.Add(new Notes(243.0f, 244.0f, "B4"));
        rightHand.Add(new Notes(245.0f, 248.0f, "A4"));
        rightHand.Add(new Notes(249.0f, 252.0f, "B4"));
        rightHand.Add(new Notes(253.0f, 256.0f, "Gsharp3"));

        rightHand.Add(new Notes(257.0f, 268.0f, "A4"));
        rightHand.Add(new Notes(269.0f, 270.0f, "C4"));
        rightHand.Add(new Notes(271.0f, 272.0f, "D4"));

        rightHand.Add(new Notes(273.0f, 278.0f, "E4"));
        rightHand.Add(new Notes(279.0f, 280.0f, "D4"));
        rightHand.Add(new Notes(281.0f, 284.0f, "E4"));
        rightHand.Add(new Notes(288.0f, 288.0f, "G4"));

        //fifth Line
        rightHand.Add(new Notes(289.0f, 300.0f, "D4"));
        rightHand.Add(new Notes(301.0f, 304.0f, "G3"));

        rightHand.Add(new Notes(305.0f, 310.0f, "C4"));
        rightHand.Add(new Notes(311.0f, 312.0f, "B4"));
        rightHand.Add(new Notes(313.0f, 316.0f, "C4"));
        rightHand.Add(new Notes(317.0f, 318.0f, "D4"));
        rightHand.Add(new Notes(319.0f, 320.0f, "E4"));

        rightHand.Add(new Notes(321.0f, 336.0f, "E4"));

        rightHand.Add(new Notes(337.0f, 338.0f, "A4"));
        rightHand.Add(new Notes(339.0f, 340.0f, "B4"));
        rightHand.Add(new Notes(341.0f, 344.0f, "C4"));
        rightHand.Add(new Notes(345.0f, 346.0f, "B4"));
        rightHand.Add(new Notes(347.0f, 348.0f, "C4"));
        rightHand.Add(new Notes(349.0f, 352.0f, "D4"));

        //Second Page
        //first line
        rightHand.Add(new Notes(353.0f, 358.0f, "C4"));
        rightHand.Add(new Notes(359.0f, 360.0f, "G3"));
        rightHand.Add(new Notes(361.0f, 368.0f, "G3"));

        rightHand.Add(new Notes(369.0f, 372.0f, "F4"));
        rightHand.Add(new Notes(373.0f, 376.0f, "E4"));
        rightHand.Add(new Notes(377.0f, 380.0f, "D4"));
        rightHand.Add(new Notes(381.0f, 384.0f, "C4"));

        rightHand.Add(new Notes(385.0f, 396.0f, "E4"));
        rightHand.Add(new Notes(397.0f, 400.0f, "E4"));

        rightHand.Add(new Notes(401.0f, 406.0f, "A5"));
        rightHand.Add(new Notes(407.0f, 408.0f, "A5"));
        rightHand.Add(new Notes(409.0f, 414.0f, "G4"));
        rightHand.Add(new Notes(415.0f, 416.0f, "G4"));

        //second line

        rightHand.Add(new Notes(417.0f, 418.0f, "E4"));
        rightHand.Add(new Notes(419.0f, 420.0f, "D4"));
        rightHand.Add(new Notes(421.0f, 428.0f, "C4"));
        rightHand.Add(new Notes(429.0f, 432.0f, "C4"));

        rightHand.Add(new Notes(433.0f, 436.0f, "D4"));
        rightHand.Add(new Notes(437.0f, 438.0f, "C4"));
        rightHand.Add(new Notes(439.0f, 444.0f, "D4"));
        rightHand.Add(new Notes(445.0f, 446.0f, "G4"));
        rightHand.Add(new Notes(447.0f, 448.0f, "E4"));

        rightHand.Add(new Notes(449.0f, 460.0f, "E4"));
        rightHand.Add(new Notes(461.0f, 464.0f, "E4"));

        rightHand.Add(new Notes(465.0f, 470.0f, "A5"));
        rightHand.Add(new Notes(471.0f, 472.0f, "A5"));
        rightHand.Add(new Notes(473.0f, 478.0f, "G4"));
        rightHand.Add(new Notes(479.0f, 480.0f, "G4"));

        //third line

        rightHand.Add(new Notes(481.0f, 482.0f, "E4"));
        rightHand.Add(new Notes(483.0f, 484.0f, "D4"));
        rightHand.Add(new Notes(485.0f, 492.0f, "C4"));
        rightHand.Add(new Notes(493.0f, 496.0f, "C4"));

        rightHand.Add(new Notes(497.0f, 500.0f, "D4"));
        rightHand.Add(new Notes(501.0f, 502.0f, "C4"));
        rightHand.Add(new Notes(503.0f, 508.0f, "D4"));
        rightHand.Add(new Notes(509.0f, 510.0f, "B4"));
        rightHand.Add(new Notes(511.0f, 512.0f, "A4"));

        rightHand.Add(new Notes(513.0f, 524.0f, "A4"));
        rightHand.Add(new Notes(525.0f, 526.0f, "A4"));
        rightHand.Add(new Notes(527.0f, 528.0f, "B4"));

        rightHand.Add(new Notes(529.0f, 534.0f, "C4"));
        rightHand.Add(new Notes(535.0f, 536.0f, "B4"));
        rightHand.Add(new Notes(537.0f, 540.0f, "C4"));
        rightHand.Add(new Notes(541.0f, 544.0f, "E4"));


        // fourth line
        rightHand.Add(new Notes(545.0f, 556.0f, "B4"));
        rightHand.Add(new Notes(557.0f, 560.0f, "E3"));

        rightHand.Add(new Notes(561.0f, 566.0f, "A4"));
        rightHand.Add(new Notes(567.0f, 568.0f, "G3"));
        rightHand.Add(new Notes(569.0f, 572.0f, "A4"));
        rightHand.Add(new Notes(573.0f, 576.0f, "C4"));

        rightHand.Add(new Notes(577.0f, 588.0f, "G3"));
        rightHand.Add(new Notes(589.0f, 592.0f, "E3"));

        rightHand.Add(new Notes(593.0f, 598.0f, "F3"));
        rightHand.Add(new Notes(599.0f, 600.0f, "E3"));
        rightHand.Add(new Notes(601.0f, 602.0f, "F3"));
        rightHand.Add(new Notes(603.0f, 608.0f, "C4"));

        // fifth line
        rightHand.Add(new Notes(609.0f, 620.0f, "E3"));
        rightHand.Add(new Notes(621.0f, 622.0f, "C4"));
        rightHand.Add(new Notes(623.0f, 624.0f, "C4"));

        rightHand.Add(new Notes(625.0f, 630.0f, "B4"));
        rightHand.Add(new Notes(631.0f, 632.0f, "Fsharp3"));
        rightHand.Add(new Notes(633.0f, 636.0f, "Fsharp3"));
        rightHand.Add(new Notes(637.0f, 640.0f, "B4"));

        rightHand.Add(new Notes(641.0f, 652.0f, "B4"));
        rightHand.Add(new Notes(653.0f, 654.0f, "A4"));
        rightHand.Add(new Notes(655.0f, 656.0f, "B4"));

        rightHand.Add(new Notes(657.0f, 662.0f, "C4"));
        rightHand.Add(new Notes(663.0f, 664.0f, "B4"));
        rightHand.Add(new Notes(665.0f, 668.0f, "C4"));
        rightHand.Add(new Notes(669.0f, 672.0f, "E4"));

        //Third Page
        //first line
        rightHand.Add(new Notes(673.0f, 684.0f, "B4"));
        rightHand.Add(new Notes(685.0f, 688.0f, "E3"));

        rightHand.Add(new Notes(689.0f, 694.0f, "A4"));
        rightHand.Add(new Notes(695.0f, 696.0f, "G3"));
        rightHand.Add(new Notes(697.0f, 700.0f, "A4"));
        rightHand.Add(new Notes(701.0f, 704.0f, "C4"));

        rightHand.Add(new Notes(705.0f, 716.0f, "G3"));
        rightHand.Add(new Notes(717.0f, 720.0f, "E3"));

        rightHand.Add(new Notes(721.0f, 724.0f, "F3"));
        rightHand.Add(new Notes(725.0f, 726.0f, "C4"));
        rightHand.Add(new Notes(727.0f, 732.0f, "B4"));
        rightHand.Add(new Notes(733.0f, 736.0f, "C4"));

        // second line
        rightHand.Add(new Notes(737.0f, 738.0f, "D4"));
        rightHand.Add(new Notes(739.0f, 742.0f, "D4"));
        rightHand.Add(new Notes(743.0f, 744.0f, "E4"));
        rightHand.Add(new Notes(745.0f, 752.0f, "C4"));

        rightHand.Add(new Notes(753.0f, 754.0f, "C4"));
        rightHand.Add(new Notes(755.0f, 756.0f, "B4"));
        rightHand.Add(new Notes(757.0f, 760.0f, "A4"));
        rightHand.Add(new Notes(761.0f, 764.0f, "B4"));
        rightHand.Add(new Notes(765.0f, 768.0f, "Gsharp3"));

        rightHand.Add(new Notes(769.0f, 780.0f, "A4"));
        rightHand.Add(new Notes(781.0f, 782.0f, "C4"));
        rightHand.Add(new Notes(783.0f, 784.0f, "D4"));

        rightHand.Add(new Notes(785.0f, 790.0f, "E4"));
        rightHand.Add(new Notes(791.0f, 792.0f, "D4"));
        rightHand.Add(new Notes(793.0f, 796.0f, "E4"));
        rightHand.Add(new Notes(797.0f, 800.0f, "G4"));

        //third line
        rightHand.Add(new Notes(801.0f, 812.0f, "D4"));
        rightHand.Add(new Notes(813.0f, 816.0f, "G3"));

        rightHand.Add(new Notes(817.0f, 822.0f, "C4"));
        rightHand.Add(new Notes(823.0f, 824.0f, "B4"));
        rightHand.Add(new Notes(825.0f, 828.0f, "C4"));
        rightHand.Add(new Notes(829.0f, 830.0f, "D4"));
        rightHand.Add(new Notes(831.0f, 832.0f, "E4"));

        rightHand.Add(new Notes(833.0f, 848.0f, "E4"));

        rightHand.Add(new Notes(849.0f, 850.0f, "A4"));
        rightHand.Add(new Notes(851.0f, 852.0f, "B4"));
        rightHand.Add(new Notes(853.0f, 856.0f, "C4"));
        rightHand.Add(new Notes(857.0f, 858.0f, "B4"));
        rightHand.Add(new Notes(859.0f, 860.0f, "C4"));
        rightHand.Add(new Notes(861.0f, 864.0f, "D4"));

        // fourth line
        rightHand.Add(new Notes(865.0f, 870.0f, "C4"));
        rightHand.Add(new Notes(871.0f, 872.0f, "G3"));
        rightHand.Add(new Notes(873.0f, 880.0f, "G3"));

        rightHand.Add(new Notes(881.0f, 884.0f, "F4"));
        rightHand.Add(new Notes(885.0f, 888.0f, "E4"));
        rightHand.Add(new Notes(889.0f, 892.0f, "D4"));
        rightHand.Add(new Notes(893.0f, 896.0f, "C4"));

        rightHand.Add(new Notes(897.0f, 908.0f, "E4"));
        rightHand.Add(new Notes(909.0f, 912.0f, "E4"));

        rightHand.Add(new Notes(913.0f, 918.0f, "A5"));
        rightHand.Add(new Notes(919.0f, 920.0f, "A5"));
        rightHand.Add(new Notes(921.0f, 926.0f, "G4"));
        rightHand.Add(new Notes(927.0f, 928.0f, "G4"));

        //fifth line
        rightHand.Add(new Notes(929.0f, 930.0f, "E4"));
        rightHand.Add(new Notes(931.0f, 932.0f, "D4"));
        rightHand.Add(new Notes(933.0f, 940.0f, "C4"));
        rightHand.Add(new Notes(941.0f, 944.0f, "C4"));

        rightHand.Add(new Notes(945.0f, 948.0f, "D4"));
        rightHand.Add(new Notes(949.0f, 950.0f, "C4"));
        rightHand.Add(new Notes(951.0f, 956.0f, "D4"));
        rightHand.Add(new Notes(957.0f, 958.0f, "G4"));
        rightHand.Add(new Notes(959.0f, 960.0f, "E4"));

        rightHand.Add(new Notes(961.0f, 972.0f, "E4"));
        rightHand.Add(new Notes(973.0f, 976.0f, "E4"));

        rightHand.Add(new Notes(977.0f, 982.0f, "A5"));
        rightHand.Add(new Notes(983.0f, 984.0f, "A5"));
        rightHand.Add(new Notes(985.0f, 990.0f, "G4"));
        rightHand.Add(new Notes(991.0f, 992.0f, "G4"));

        //fourth page
        //first line
        rightHand.Add(new Notes(993.0f, 994.0f, "E4"));
        rightHand.Add(new Notes(995.0f, 996.0f, "D4"));
        rightHand.Add(new Notes(997.0f, 1004.0f, "C4"));
        rightHand.Add(new Notes(1005.0f, 1008.0f, "C4"));

        rightHand.Add(new Notes(1009.0f, 1012.0f, "D4"));
        rightHand.Add(new Notes(1013.0f, 1014.0f, "C4"));
        rightHand.Add(new Notes(1015.0f, 1020.0f, "D4"));
        rightHand.Add(new Notes(1021.0f, 1022.0f, "B4"));
        rightHand.Add(new Notes(1023.0f, 1024.0f, "A4"));

        rightHand.Add(new Notes(1025.0f, 1036.0f, "A4"));
        rightHand.Add(new Notes(1037.0f, 1038.0f, "A4"));
        rightHand.Add(new Notes(1039.0f, 1040.0f, "B4"));

        rightHand.Add(new Notes(1041.0f, 1046.0f, "C4"));
        rightHand.Add(new Notes(1047.0f, 1048.0f, "B4"));
        rightHand.Add(new Notes(1049.0f, 1052.0f, "C4"));
        rightHand.Add(new Notes(1053.0f, 1056.0f, "E4"));

        //second line
        rightHand.Add(new Notes(1057.0f, 1068.0f, "B4"));
        rightHand.Add(new Notes(1069.0f, 1072.0f, "E3"));

        rightHand.Add(new Notes(1073.0f, 1078.0f, "A4"));
        rightHand.Add(new Notes(1079.0f, 1080.0f, "G3"));
        rightHand.Add(new Notes(1081.0f, 1084.0f, "A4"));
        rightHand.Add(new Notes(1085.0f, 1088.0f, "C4"));

        rightHand.Add(new Notes(1089.0f, 1100.0f, "G3"));
        rightHand.Add(new Notes(1101.0f, 1104.0f, "E3"));

        rightHand.Add(new Notes(1105.0f, 1110.0f, "F3"));
        rightHand.Add(new Notes(1111.0f, 1112.0f, "E3"));
        rightHand.Add(new Notes(1113.0f, 1114.0f, "F3"));
        rightHand.Add(new Notes(1115.0f, 1120.0f, "C4"));

        //third line
        rightHand.Add(new Notes(1121.0f, 1132.0f, "E3"));
        rightHand.Add(new Notes(1133.0f, 1134.0f, "C4"));
        rightHand.Add(new Notes(1135.0f, 1136.0f, "C4"));

        rightHand.Add(new Notes(1137.0f, 1142.0f, "B4"));
        rightHand.Add(new Notes(1143.0f, 1144.0f, "Fsharp3"));
        rightHand.Add(new Notes(1145.0f, 1148.0f, "Fsharp3"));
        rightHand.Add(new Notes(1149.0f, 1152.0f, "B4"));

        rightHand.Add(new Notes(1153.0f, 1164.0f, "B4"));
        rightHand.Add(new Notes(1165.0f, 1166.0f, "A4"));
        rightHand.Add(new Notes(1167.0f, 1168.0f, "B4"));

        rightHand.Add(new Notes(1169.0f, 1174.0f, "C4"));
        rightHand.Add(new Notes(1175.0f, 1176.0f, "B4"));
        rightHand.Add(new Notes(1177.0f, 1180.0f, "C4"));
        rightHand.Add(new Notes(1181.0f, 1184.0f, "E4"));

        //fourth line
        rightHand.Add(new Notes(1185.0f, 1196.0f, "B4"));
        rightHand.Add(new Notes(1197.0f, 1200.0f, "E3"));

        rightHand.Add(new Notes(1201.0f, 1206.0f, "A4"));
        rightHand.Add(new Notes(1207.0f, 1208.0f, "G3"));
        rightHand.Add(new Notes(1209.0f, 1212.0f, "A4"));
        rightHand.Add(new Notes(1213.0f, 1216.0f, "C4"));

        rightHand.Add(new Notes(1217.0f, 1228.0f, "G3"));
        rightHand.Add(new Notes(1229.0f, 1232.0f, "E3"));

        rightHand.Add(new Notes(1233.0f, 1236.0f, "F3"));
        rightHand.Add(new Notes(1237.0f, 1238.0f, "C4"));
        rightHand.Add(new Notes(1239.0f, 1244.0f, "B4"));
        rightHand.Add(new Notes(1245.0f, 1248.0f, "C4"));

        //fifth line
        rightHand.Add(new Notes(1249.0f, 1250.0f, "D4"));
        rightHand.Add(new Notes(1251.0f, 1254.0f, "D4"));
        rightHand.Add(new Notes(1255.0f, 1256.0f, "E4"));
        rightHand.Add(new Notes(1257.0f, 1264.0f, "C4"));

        rightHand.Add(new Notes(1265.0f, 1266.0f, "C4"));
        rightHand.Add(new Notes(1267.0f, 1268.0f, "B4"));
        rightHand.Add(new Notes(1269.0f, 1272.0f, "A4"));
        rightHand.Add(new Notes(1273.0f, 1276.0f, "B4"));
        rightHand.Add(new Notes(1277.0f, 1280.0f, "Gsharp3"));

        rightHand.Add(new Notes(1281.0f, 1296.0f, "A4"));

        rightHand.Add(new Notes(1297.0f, 1298.0f, "C4"));
        rightHand.Add(new Notes(1299.0f, 1300.0f, "B4"));
        rightHand.Add(new Notes(1301.0f, 1304.0f, "A4"));
        rightHand.Add(new Notes(1305.0f, 1308.0f, "B4"));
        rightHand.Add(new Notes(1309.0f, 1312.0f, "Gsharp3"));

        rightHand.Add(new Notes(1313.0f, 1328.0f, "C3"));
        rightHand.Add(new Notes(1313.0f, 1328.0f, "E3"));
        rightHand.Add(new Notes(1313.0f, 1328.0f, "A4"));

        
        //left hand
        //first page
        //first line
        leftHand.Add(new Notes(17.0f, 20.0f, "A2"));
        leftHand.Add(new Notes(21.0f, 24.0f, "E2"));
        leftHand.Add(new Notes(25.0f, 32.0f, "A3"));

        leftHand.Add(new Notes(33.0f, 36.0f, "E1"));
        leftHand.Add(new Notes(37.0f, 40.0f, "B2"));
        leftHand.Add(new Notes(41.0f, 48.0f, "E2"));

        leftHand.Add(new Notes(49.0f, 52.0f, "F1"));
        leftHand.Add(new Notes(53.0f, 56.0f, "C2"));
        leftHand.Add(new Notes(57.0f, 64.0f, "F2"));
        //second line
        leftHand.Add(new Notes(65.0f, 68.0f, "C2"));
        leftHand.Add(new Notes(69.0f, 72.0f, "G2"));
        leftHand.Add(new Notes(73.0f, 80.0f, "C3"));

        leftHand.Add(new Notes(81.0f, 84.0f, "D2"));
        leftHand.Add(new Notes(85.0f, 88.0f, "A3"));
        leftHand.Add(new Notes(89.0f, 96.0f, "D3"));

        leftHand.Add(new Notes(97.0f, 100.0f,"A2"));
        leftHand.Add(new Notes(101.0f, 104.0f, "E2"));
        leftHand.Add(new Notes(105.0f, 112.0f, "C3"));

        leftHand.Add(new Notes(113.0f, 116.0f, "B2"));
        leftHand.Add(new Notes(117.0f, 120.0f, "Fsharp2"));
        leftHand.Add(new Notes(121.0f, 124.0f, "B3"));
        leftHand.Add(new Notes(125.0f, 128.0f, "Fsharp2"));

        leftHand.Add(new Notes(129.0f, 130.0f, "E1"));
        leftHand.Add(new Notes(131.0f, 132.0f, "B2"));
        leftHand.Add(new Notes(133.0f, 134.0f, "E2"));
        leftHand.Add(new Notes(135.0f, 136.0f, "Gsharp2"));
        leftHand.Add(new Notes(137.0f, 144.0f, "B3"));

        //third line
        leftHand.Add(new Notes(145.0f, 146.0f, "A2"));
        leftHand.Add(new Notes(147.0f, 148.0f, "E2"));
        leftHand.Add(new Notes(149.0f, 150.0f, "A3"));
        leftHand.Add(new Notes(151.0f, 152.0f, "E2"));
        leftHand.Add(new Notes(153.0f, 154.0f, "A2"));
        leftHand.Add(new Notes(155.0f, 158.0f, "E2"));
        leftHand.Add(new Notes(157.0f, 158.0f, "A3"));
        leftHand.Add(new Notes(159.0f, 160.0f, "E2"));

        leftHand.Add(new Notes(161.0f, 162.0f, "E1"));
        leftHand.Add(new Notes(163.0f, 164.0f, "B2"));
        leftHand.Add(new Notes(165.0f, 166.0f, "E2"));
        leftHand.Add(new Notes(167.0f, 168.0f, "G2"));
        leftHand.Add(new Notes(169.0f, 176.0f, "B3"));

        leftHand.Add(new Notes(177.0f, 178.0f, "F1"));
        leftHand.Add(new Notes(179.0f, 180.0f, "C2"));
        leftHand.Add(new Notes(181.0f, 182.0f, "F2"));
        leftHand.Add(new Notes(183.0f, 184.0f, "C2"));
        leftHand.Add(new Notes(185.0f, 186.0f, "F1"));
        leftHand.Add(new Notes(187.0f, 188.0f, "C2"));
        leftHand.Add(new Notes(189.0f, 190.0f, "F2"));
        leftHand.Add(new Notes(191.0f, 192.0f, "C2"));

        leftHand.Add(new Notes(193.0f, 194.0f, "C1"));
        leftHand.Add(new Notes(195.0f, 196.0f, "G1"));
        leftHand.Add(new Notes(197.0f, 198.0f, "C2"));
        leftHand.Add(new Notes(199.0f, 200.0f, "G2"));
        leftHand.Add(new Notes(201.0f, 208.0f, "C3"));

        leftHand.Add(new Notes(209.0f, 210.0f, "D1"));
        leftHand.Add(new Notes(211.0f, 212.0f, "A2"));
        leftHand.Add(new Notes(213.0f, 214.0f, "D2"));
        leftHand.Add(new Notes(215.0f, 216.0f, "F2"));
        leftHand.Add(new Notes(217.0f, 218.0f, "A3"));
        leftHand.Add(new Notes(219.0f, 224.0f, "D3"));
        //fourth line
        leftHand.Add(new Notes(225.0f, 226.0f, "A2"));
        leftHand.Add(new Notes(227.0f, 228.0f, "E2"));
        leftHand.Add(new Notes(229.0f, 230.0f, "A3"));
        leftHand.Add(new Notes(231.0f, 232.0f, "C3"));
        leftHand.Add(new Notes(234.0f, 236.0f, "E3"));
        leftHand.Add(new Notes(237.0f, 240.0f, "C3"));

        leftHand.Add(new Notes(241.0f, 242.0f, "F2"));
        leftHand.Add(new Notes(243.0f, 244.0f, "A3"));
        leftHand.Add(new Notes(245.0f, 246.0f, "C3"));
        leftHand.Add(new Notes(247.0f, 248.0f, "A3"));
        leftHand.Add(new Notes(249.0f, 250.0f, "E2"));
        leftHand.Add(new Notes(251.0f, 252.0f, "Gsharp2"));
        leftHand.Add(new Notes(253.0f, 254.0f, "B3"));
        leftHand.Add(new Notes(255.0f, 256.0f, "Gsharp2"));

        leftHand.Add(new Notes(257.0f, 258.0f, "A2"));
        leftHand.Add(new Notes(259.0f, 260.0f, "E2"));
        leftHand.Add(new Notes(261.0f, 262.0f, "A3"));
        leftHand.Add(new Notes(263.0f, 264.0f, "C3"));
        leftHand.Add(new Notes(265.0f, 272.0f, "E3"));

        leftHand.Add(new Notes(273.0f, 274.0f, "C2"));
        leftHand.Add(new Notes(275.0f, 276.0f, "G2"));
        leftHand.Add(new Notes(277.0f, 278.0f, "C3"));
        leftHand.Add(new Notes(279.0f, 280.0f, "G2"));
        leftHand.Add(new Notes(281.0f, 282.0f, "C2"));
        leftHand.Add(new Notes(283.0f, 284.0f, "G2"));
        leftHand.Add(new Notes(285.0f, 286.0f, "C3"));
        leftHand.Add(new Notes(287.0f, 288.0f, "G2"));
        

        //fifth line
        leftHand.Add(new Notes(289.0f, 290.0f, "G1"));
        leftHand.Add(new Notes(291.0f, 292.0f, "D2"));
        leftHand.Add(new Notes(293.0f, 294.0f, "G2"));
        leftHand.Add(new Notes(295.0f, 296.0f, "B3"));
        leftHand.Add(new Notes(297.0f, 300.0f, "D3"));
        leftHand.Add(new Notes(301.0f, 304.0f, "B3"));

        leftHand.Add(new Notes(305.0f, 306.0f, "A2"));
        leftHand.Add(new Notes(307.0f, 308.0f, "E2"));
        leftHand.Add(new Notes(309.0f, 310.0f, "A3"));
        leftHand.Add(new Notes(311.0f, 312.0f, "E2"));
        leftHand.Add(new Notes(313.0f, 314.0f, "A2"));
        leftHand.Add(new Notes(315.0f, 316.0f, "E2"));
        leftHand.Add(new Notes(317.0f, 318.0f, "A3"));
        leftHand.Add(new Notes(319.0f, 320.0f, "E2"));

        leftHand.Add(new Notes(321.0f, 322.0f, "E1"));
        leftHand.Add(new Notes(323.0f, 324.0f, "B2"));
        leftHand.Add(new Notes(325.0f, 326.0f, "E3"));
        leftHand.Add(new Notes(327.0f, 328.0f, "G2"));
        leftHand.Add(new Notes(329.0f, 332.0f, "B3"));
        leftHand.Add(new Notes(333.0f, 336.0f, "G2"));

        leftHand.Add(new Notes(337.0f, 338.0f, "F1"));
        leftHand.Add(new Notes(339.0f, 340.0f, "C2"));
        leftHand.Add(new Notes(341.0f, 342.0f, "F2"));
        leftHand.Add(new Notes(343.0f, 344.0f, "A3"));
        leftHand.Add(new Notes(345.0f, 346.0f, "G1"));
        leftHand.Add(new Notes(347.0f, 348.0f, "B2"));
        leftHand.Add(new Notes(349.0f, 350.0f, "D3"));
        leftHand.Add(new Notes(351.0f, 352.0f, "G2"));

        //second Page





















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
