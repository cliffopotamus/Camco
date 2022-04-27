using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamcoForm
{
    public partial class NewInventoryForm : Form
    {
        public NewInventoryForm()
        {
            InitializeComponent();
            PopulateCombo();
        }

        private void NewInventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'camcoDataSet8.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter2.Fill(this.camcoDataSet8.Inventory);
            // TODO: This line of code loads data into the 'camcoDataSet7.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter1.Fill(this.camcoDataSet7.Inventory);
            // TODO: This line of code loads data into the 'realInventory.Inventory' table. You can move, or remove it, as needed.


        }

        public class InventoryBox
        {
            public int ID;
            public string DisplayName;

            public InventoryBox(int pID, string pName)
            {
                ID = pID;
                DisplayName = pName;
            }

            public override string ToString()
            {
                return DisplayName;
            }
        }

        private void PopulateCombo()
        {
            InventoryBox c1 = new InventoryBox(1, "FW316-1");
            InventoryBox c2 = new InventoryBox(2, "SAEFW10");
            InventoryBox c3 = new InventoryBox(3, "PBit2");
            InventoryBox c4 = new InventoryBox(4, "1box");
            InventoryBox c5 = new InventoryBox(5, "FW12");
            InventoryBox c6 = new InventoryBox(6, "HFN12");
            InventoryBox c7 = new InventoryBox(7, "NLN12");
            InventoryBox c8 = new InventoryBox(8, "SLW12");
            InventoryBox c9 = new InventoryBox(9, "USSFW12");
            InventoryBox c10 = new InventoryBox(10, "FW12-112");
            InventoryBox c11 = new InventoryBox(11, "TB12-112");
            InventoryBox c12 = new InventoryBox(12, "TB12-1");
            InventoryBox c13 = new InventoryBox(13, "MK12-2L");
            InventoryBox c14 = new InventoryBox(14, "TB12-2");
            InventoryBox c15 = new InventoryBox(15, "TB12-34");
            InventoryBox c16 = new InventoryBox(16, "MDrill12");
            InventoryBox c17 = new InventoryBox(17, "Drop-in 14");
            InventoryBox c18 = new InventoryBox(18, "MS14-112");
            InventoryBox c19 = new InventoryBox(19, "MS14-114");
            InventoryBox c20 = new InventoryBox(20, "MS14-1");
            InventoryBox c21 = new InventoryBox(21, "MS14-12");
            InventoryBox c22 = new InventoryBox(22, "MS14-2");
            InventoryBox c23 = new InventoryBox(23, "MS14-34");
            InventoryBox c24 = new InventoryBox(24, "GF1428-45");
            InventoryBox c25 = new InventoryBox(25, "EYELAG14");
            InventoryBox c26 = new InventoryBox(26, "Lags14-3");
            InventoryBox c27 = new InventoryBox(27, "HFN14");
            InventoryBox c28 = new InventoryBox(28, "KLN14");
            InventoryBox c29 = new InventoryBox(29, "Mdrill14");
            InventoryBox c30 = new InventoryBox(30, "SAEFW14");
            InventoryBox c31 = new InventoryBox(31, "SLW14");
            InventoryBox c32 = new InventoryBox(32, "USSFW14");
            InventoryBox c33 = new InventoryBox(33, "RANChor14-1");
            InventoryBox c34 = new InventoryBox(34, "TB14-112");
            InventoryBox c35 = new InventoryBox(35, "MK14-112L");
            InventoryBox c36 = new InventoryBox(36, "BAnchor141");
            InventoryBox c37 = new InventoryBox(37, "FW14-1");
            InventoryBox c38 = new InventoryBox(38, "TB14-1");
            InventoryBox c39 = new InventoryBox(39, "TB14-12");
            InventoryBox c40 = new InventoryBox(40, "TB14-2");
            InventoryBox c41 = new InventoryBox(41, "ToB14-3");
            InventoryBox c42 = new InventoryBox(42, "TB14-34");
            InventoryBox c43 = new InventoryBox(43, "SS5-1420-12");
            InventoryBox c44 = new InventoryBox(44, "SS5-1420-14");
            InventoryBox c45 = new InventoryBox(45, "SS5-1420-34");
            InventoryBox c46 = new InventoryBox(46, "SS5-1420-38");
            InventoryBox c47 = new InventoryBox(47, "GF1428-90");
            InventoryBox c48 = new InventoryBox(48, "SS5-1428-12");
            InventoryBox c49 = new InventoryBox(49, "SS5-1428-14");
            InventoryBox c50 = new InventoryBox(50, "SS5-1428-34");
            InventoryBox c51 = new InventoryBox(51, "SS5-1428-38");
            InventoryBox c52 = new InventoryBox(52, "GF1428ST");
            InventoryBox c53 = new InventoryBox(53, "GF-45");
            InventoryBox c54 = new InventoryBox(54, "GF-90");
            InventoryBox c55 = new InventoryBox(55, "GF-64-01 ST");
            InventoryBox c56 = new InventoryBox(56, "MK-18-112L");
            InventoryBox c57 = new InventoryBox(57, "ZIP10-112");
            InventoryBox c58 = new InventoryBox(58, "Tek10-112");
            InventoryBox c59 = new InventoryBox(59, "ZIP10-114");
            InventoryBox c60 = new InventoryBox(60, "Tek10-114");
            InventoryBox c61 = new InventoryBox(61, "Cpan10-1F");
            InventoryBox c62 = new InventoryBox(62, "Cpan10-1T");
            InventoryBox c63 = new InventoryBox(63, "Tek10-1");
            InventoryBox c64 = new InventoryBox(64, "Zip10-1");
            InventoryBox c65 = new InventoryBox(65, "Pan10-1");
            InventoryBox c66 = new InventoryBox(66, "ZIP10-12");
            InventoryBox c67 = new InventoryBox(67, "PAN1012");
            InventoryBox c68 = new InventoryBox(68, "Tek1012");
            InventoryBox c69 = new InventoryBox(69, "PAN10212");
            InventoryBox c70 = new InventoryBox(70, "ZIP102");
            InventoryBox c71 = new InventoryBox(71, "PAN102");
            InventoryBox c72 = new InventoryBox(72, "ZIP1034");
            InventoryBox c73 = new InventoryBox(73, "PAN1034");
            InventoryBox c74 = new InventoryBox(74, "TEK1034");
            InventoryBox c75 = new InventoryBox(75, "TEK1058");
            InventoryBox c76 = new InventoryBox(76, "TWB100-14");
            InventoryBox c77 = new InventoryBox(77, "TWB100-18");
            InventoryBox c78 = new InventoryBox(78, "TWY100-18");
            InventoryBox c79 = new InventoryBox(79, "TWY100-14");
            InventoryBox c80 = new InventoryBox(80, "1024MSN");
            InventoryBox c81 = new InventoryBox(81, "1024KN");
            InventoryBox c82 = new InventoryBox(82, "1024NC12");
            InventoryBox c83 = new InventoryBox(83, "1024NC14");
            InventoryBox c84 = new InventoryBox(84, "1024NC38");
            InventoryBox c85 = new InventoryBox(85, "1024SAE");
            InventoryBox c86 = new InventoryBox(86, "1024112MS");
            InventoryBox c87 = new InventoryBox(87, "test");
            InventoryBox c89 = new InventoryBox(89, "Drop-in 38");
            InventoryBox c90 = new InventoryBox(90, "38Stool");
            InventoryBox c91 = new InventoryBox(91, "DWS61");
            InventoryBox c92 = new InventoryBox(92, "DWS6158");
            InventoryBox c93 = new InventoryBox(93, "Mbholder");
            InventoryBox c94 = new InventoryBox(94, "Cpan8-114");
            InventoryBox c95 = new InventoryBox(95, "Panchor-white");
            InventoryBox c96 = new InventoryBox(96, "pflat634");
            InventoryBox c97 = new InventoryBox(97, "Cpan8-1");
            InventoryBox c98 = new InventoryBox(98, "Mdrill316");
            InventoryBox c99 = new InventoryBox(99, "Panc316-78R");
            InventoryBox c100 = new InventoryBox(100, "pflat8-1");
            InventoryBox c101 = new InventoryBox(101, "Cpan634");
            InventoryBox c102 = new InventoryBox(102, "Panch-516-114B");
            InventoryBox c103 = new InventoryBox(103, "Cpan-12-114");
            InventoryBox c104 = new InventoryBox(104, "Mdrill516");
            InventoryBox c105 = new InventoryBox(105, "316-str64-12");
            InventoryBox c106 = new InventoryBox(106, "GF-516-64-13");
            InventoryBox c107 = new InventoryBox(107, "Zip8-12");
            InventoryBox c108 = new InventoryBox(108, "Zip8-34");
            InventoryBox c109 = new InventoryBox(109, "Zip8-1");
            InventoryBox c110 = new InventoryBox(110, "Zip8-114");
            InventoryBox c111 = new InventoryBox(111, "Zip8-112");
            InventoryBox c113 = new InventoryBox(113, "HC-300-004");
            InventoryBox c114 = new InventoryBox(114, "HC-300-006");
            InventoryBox c115 = new InventoryBox(115, "HC-300-008");
            InventoryBox c116 = new InventoryBox(116, "HC-300-012");
            InventoryBox c117 = new InventoryBox(117, "HC-600-016");
            InventoryBox c118 = new InventoryBox(118, "HC-600-020");
            InventoryBox c119 = new InventoryBox(119, "HC-600-028");
            InventoryBox c120 = new InventoryBox(120, "LAGS-38-1");
            InventoryBox c121 = new InventoryBox(121, "LAGS-38-112");
            InventoryBox c122 = new InventoryBox(122, "LAGS-38-2");
            InventoryBox c123 = new InventoryBox(123, "LAGS-38-212");
            InventoryBox c124 = new InventoryBox(124, "LAGS-38-3");
            InventoryBox c125 = new InventoryBox(125, "MK-316-112L");
            InventoryBox c126 = new InventoryBox(126, "MK-516-112");
            InventoryBox c127 = new InventoryBox(127, "MK-38-112L");
            InventoryBox c128 = new InventoryBox(128, "632MSN");
            InventoryBox c129 = new InventoryBox(129, "2box");
            InventoryBox c130 = new InventoryBox(130, "6box");
            InventoryBox c131 = new InventoryBox(131, "632KLN");
            InventoryBox c132 = new InventoryBox(132, "632NYN");
            InventoryBox c133 = new InventoryBox(133, "SAEF632-6");
            InventoryBox c134 = new InventoryBox(134, "632SLW6");
            InventoryBox c135 = new InventoryBox(135, "Cnut6-32");
            InventoryBox c136 = new InventoryBox(136, "632-112MS");
            InventoryBox c137 = new InventoryBox(137, "832MSN");
            InventoryBox c138 = new InventoryBox(138, "832KLN");
            InventoryBox c139 = new InventoryBox(139, "832NYN");
            InventoryBox c140 = new InventoryBox(140, "832SFN");
            InventoryBox c141 = new InventoryBox(141, "Cnut8-32");
            InventoryBox c142 = new InventoryBox(142, "832WN");
            InventoryBox c143 = new InventoryBox(143, "SAEF832-8");
            InventoryBox c144 = new InventoryBox(144, "832SLW8");
            InventoryBox c145 = new InventoryBox(145, "832-12MS");
            InventoryBox c146 = new InventoryBox(146, "832-34MS");
            InventoryBox c147 = new InventoryBox(147, "832-114MS");
            InventoryBox c148 = new InventoryBox(148, "1032HN");
            InventoryBox c149 = new InventoryBox(149, "1032KLN");
            InventoryBox c150 = new InventoryBox(150, "1032NLN");
            InventoryBox c151 = new InventoryBox(151, "1032SFN");
            InventoryBox c152 = new InventoryBox(152, "1032CN");
            InventoryBox c153 = new InventoryBox(153, "1032WN");
            InventoryBox c154 = new InventoryBox(154, "1032SLW10");
            InventoryBox c156 = new InventoryBox(156, "1032114MS");
            InventoryBox c157 = new InventoryBox(157, "NLIstop-14");
            InventoryBox c158 = new InventoryBox(158, "NLIstop-516");
            InventoryBox c159 = new InventoryBox(159, "NLIstop-38");
            InventoryBox c160 = new InventoryBox(160, "NLIstop-12");
            InventoryBox c161 = new InventoryBox(161, "632-38MS");
            InventoryBox c162 = new InventoryBox(162, "632-12MS");
            InventoryBox c163 = new InventoryBox(163, "632-34MS");
            InventoryBox c164 = new InventoryBox(164, "632-1MS");
            InventoryBox c166 = new InventoryBox(166, "632-114MS");
            InventoryBox c167 = new InventoryBox(167, "632-2MS");
            InventoryBox c169 = new InventoryBox(169, "832-38MS");
            InventoryBox c170 = new InventoryBox(170, "832-1MS");
            InventoryBox c171 = new InventoryBox(171, "832-112MS");
            InventoryBox c172 = new InventoryBox(172, "832-2MS");
            InventoryBox c173 = new InventoryBox(173, "103238MS");
            InventoryBox c174 = new InventoryBox(174, "103212MS");
            InventoryBox c175 = new InventoryBox(175, "103234MS");
            InventoryBox c176 = new InventoryBox(176, "10321MS");
            InventoryBox c177 = new InventoryBox(177, "1032114MS");
            InventoryBox c178 = new InventoryBox(178, "1832112MS");
            InventoryBox c179 = new InventoryBox(179, "10322MS");
            InventoryBox c182 = new InventoryBox(182, "TB38-34");
            InventoryBox c183 = new InventoryBox(183, "TB38-1");
            InventoryBox c184 = new InventoryBox(184, "TB38-112");
            InventoryBox c185 = new InventoryBox(185, "TB38-2");
            InventoryBox c186 = new InventoryBox(186, "USSFW38");
            InventoryBox c187 = new InventoryBox(187, "HFN38");
            InventoryBox c188 = new InventoryBox(188, "KLN38");
            InventoryBox c189 = new InventoryBox(189, "SLW38");
            InventoryBox c190 = new InventoryBox(190, "FW38-112");
            InventoryBox c191 = new InventoryBox(191, "TB516-34");
            InventoryBox c192 = new InventoryBox(192, "TB516-1");
            InventoryBox c193 = new InventoryBox(193, "TB516-112");
            InventoryBox c194 = new InventoryBox(194, "TB516-2");
            InventoryBox c195 = new InventoryBox(195, "USSFW516");
            InventoryBox c196 = new InventoryBox(196, "HFN516");
            InventoryBox c197 = new InventoryBox(197, "KLN516");
            InventoryBox c198 = new InventoryBox(198, "SLW516");
            InventoryBox c199 = new InventoryBox(199, "FW516-114");
            InventoryBox c202 = new InventoryBox(202, "SLW58");
            InventoryBox c203 = new InventoryBox(203, "516-18NC14");
            InventoryBox c204 = new InventoryBox(204, "516-18N38");
            InventoryBox c205 = new InventoryBox(205, "516-18N12");
            InventoryBox c206 = new InventoryBox(206, "516-18NC34");
            InventoryBox c207 = new InventoryBox(207, "516-24NF14");
            InventoryBox c208 = new InventoryBox(208, "516-24NF38");
            InventoryBox c209 = new InventoryBox(209, "516-24NF12");
            InventoryBox c210 = new InventoryBox(210, "516-24NF34");
            InventoryBox c211 = new InventoryBox(211, "1032NF14");
            InventoryBox c212 = new InventoryBox(212, "1032NF38");
            InventoryBox c213 = new InventoryBox(213, "1032NF12");
            InventoryBox c214 = new InventoryBox(214, "TEK8-12");
            InventoryBox c215 = new InventoryBox(215, "TEK8-34");
            InventoryBox c216 = new InventoryBox(216, "TEK8-1");
            InventoryBox c217 = new InventoryBox(217, "TEK8-114");
            InventoryBox c218 = new InventoryBox(218, "TEK8-112");
            InventoryBox c219 = new InventoryBox(219, "JC-2");
            InventoryBox c220 = new InventoryBox(220, "JC-15");
            InventoryBox c221 = new InventoryBox(221, "TEK12-34");
            InventoryBox c222 = new InventoryBox(222, "TEK12-1");
            InventoryBox c223 = new InventoryBox(223, "Tek12-114");
            InventoryBox c224 = new InventoryBox(224, "Tek12-112");
            InventoryBox c225 = new InventoryBox(225, "Tek12-2");
            InventoryBox c227 = new InventoryBox(227, "Tek14-34");
            InventoryBox c228 = new InventoryBox(228, "Tek14-1");
            InventoryBox c229 = new InventoryBox(229, "Tek14-114");
            InventoryBox c230 = new InventoryBox(230, "Tek14-112");
            InventoryBox c231 = new InventoryBox(231, "Tek14-2");
            InventoryBox c232 = new InventoryBox(232, "JC-30");
            InventoryBox c233 = new InventoryBox(233, "SAEFW516");
            InventoryBox c234 = new InventoryBox(234, "SAEFW38");
            InventoryBox c236 = new InventoryBox(236, "WedgeAnc-38-3");
            InventoryBox c237 = new InventoryBox(237, "Mdrill38");
            InventoryBox c238 = new InventoryBox(238, "Drop-in-12");
            InventoryBox c239 = new InventoryBox(239, "TB14-4");
            InventoryBox c240 = new InventoryBox(240, "TB18-4");
            InventoryBox c241 = new InventoryBox(241, "Zip12-114");
            InventoryBox c242 = new InventoryBox(242, "1024114MS");
            InventoryBox c243 = new InventoryBox(243, "10241MS");
            InventoryBox c244 = new InventoryBox(244, "102412MS");
            InventoryBox c245 = new InventoryBox(245, "10242MS");
            InventoryBox c246 = new InventoryBox(246, "102434MS");
            InventoryBox c247 = new InventoryBox(247, "102438MS");
            InventoryBox c248 = new InventoryBox(248, "10241-4MS");
            InventoryBox c249 = new InventoryBox(249, "Hood010604");
            InventoryBox c250 = new InventoryBox(250, "Vinyl110059");
            InventoryBox c251 = new InventoryBox(251, "Periscope110117");
            InventoryBox c252 = new InventoryBox(252, "Periscope110140");
            InventoryBox c253 = new InventoryBox(253, "Foil110219");
            InventoryBox c254 = new InventoryBox(254, "Foil110220");
            InventoryBox c255 = new InventoryBox(255, "Hood110277");
            InventoryBox c256 = new InventoryBox(256, "Duct110434");
            InventoryBox c257 = new InventoryBox(257, "Hood110533");
            InventoryBox c258 = new InventoryBox(258, "Hood110603");
            InventoryBox c259 = new InventoryBox(259, "Pipe110400");
            InventoryBox c260 = new InventoryBox(260, "Hood111522");
            InventoryBox c261 = new InventoryBox(261, "TW250-14G-B");
            InventoryBox c262 = new InventoryBox(262, "TW250-1G-Y");
            InventoryBox c263 = new InventoryBox(263, "TW250-18G-B");
            InventoryBox c264 = new InventoryBox(264, "TW250-18G-Y");
            InventoryBox c265 = new InventoryBox(265, "HC-300-010");
            InventoryBox c266 = new InventoryBox(266, "HC-350-004");
            InventoryBox c267 = new InventoryBox(267, "HC-350-006");
            InventoryBox c268 = new InventoryBox(268, "HC-350-008");
            InventoryBox c269 = new InventoryBox(269, "HC-350-010");
            InventoryBox c270 = new InventoryBox(270, "HC-350-012");
            InventoryBox c271 = new InventoryBox(271, "DWS6212");
            InventoryBox c272 = new InventoryBox(272, "DWS6214");
            InventoryBox c273 = new InventoryBox(273, "HC-600-006");
            InventoryBox c274 = new InventoryBox(274, "HC-600-008");
            InventoryBox c275 = new InventoryBox(275, "HC-600-010");
            InventoryBox c276 = new InventoryBox(276, "HC-600-012");
            InventoryBox c277 = new InventoryBox(277, "HC-600-024");
            InventoryBox c278 = new InventoryBox(278, "HC-600-032");
            InventoryBox c279 = new InventoryBox(279, "HC-600-036");
            InventoryBox c280 = new InventoryBox(280, "HC-600-052");
            InventoryBox c281 = new InventoryBox(281, "HC-600-104");
            InventoryBox c282 = new InventoryBox(282, "HC-611-036");
            InventoryBox c283 = new InventoryBox(283, "HC-620-006");
            InventoryBox c284 = new InventoryBox(284, "HC-620-008");
            InventoryBox c285 = new InventoryBox(285, "HC-620-010");
            InventoryBox c286 = new InventoryBox(286, "HC-620-012");
            InventoryBox c287 = new InventoryBox(287, "HC-620-016");
            InventoryBox c288 = new InventoryBox(288, "HC-620-020");
            InventoryBox c289 = new InventoryBox(289, "HC-620-024");
            InventoryBox c290 = new InventoryBox(290, "HC-620-028");
            InventoryBox c291 = new InventoryBox(291, "HC-620-032");
            InventoryBox c292 = new InventoryBox(292, "HC-620-036");
            InventoryBox c293 = new InventoryBox(293, "HC-620-052");
            InventoryBox c294 = new InventoryBox(294, "DWS8-212");
            InventoryBox c295 = new InventoryBox(295, "DWS8-3");
            InventoryBox c296 = new InventoryBox(296, "CDC912");
            InventoryBox c297 = new InventoryBox(297, "CDC415");
            InventoryBox c298 = new InventoryBox(298, "CMD10A");
            InventoryBox c299 = new InventoryBox(299, "EZTBolt");
            InventoryBox c300 = new InventoryBox(300, "GL23008");
            InventoryBox c301 = new InventoryBox(301, "JC-10-4");
            InventoryBox c302 = new InventoryBox(302, "JC-10-5");
            InventoryBox c303 = new InventoryBox(303, "JC-10-6");
            InventoryBox c304 = new InventoryBox(304, "JC-12-4");
            InventoryBox c305 = new InventoryBox(305, "JC-12-5");
            InventoryBox c306 = new InventoryBox(306, "JC-12-6");
            InventoryBox c307 = new InventoryBox(307, "JC-6-4");
            InventoryBox c308 = new InventoryBox(308, "JC-6-5");
            InventoryBox c309 = new InventoryBox(309, "Jc-6-6");
            InventoryBox c310 = new InventoryBox(310, "LL-10016");
            InventoryBox c311 = new InventoryBox(311, "LL-10004");
            InventoryBox c312 = new InventoryBox(312, "LL-10001");
            InventoryBox c313 = new InventoryBox(313, "Manchor");
            InventoryBox c314 = new InventoryBox(314, "Ring407");
            InventoryBox c315 = new InventoryBox(315, "PB-1");
            InventoryBox c316 = new InventoryBox(316, "PB-2");
            InventoryBox c317 = new InventoryBox(317, "PB-3");
            InventoryBox c318 = new InventoryBox(318, "PB-4");
            InventoryBox c319 = new InventoryBox(319, "PB2bit");
            InventoryBox c320 = new InventoryBox(320, "Repoxy");
            InventoryBox c321 = new InventoryBox(321, "SPG-55279");
            InventoryBox c322 = new InventoryBox(322, "SPG-55275");
            InventoryBox c323 = new InventoryBox(323, "SPGB-55276");
            InventoryBox c324 = new InventoryBox(324, "SPGW-55274");
            InventoryBox c325 = new InventoryBox(325, "SPW-55280");
            InventoryBox c326 = new InventoryBox(326, "Tzone-17001");
            InventoryBox c327 = new InventoryBox(327, "Tzone-17004");
            InventoryBox c328 = new InventoryBox(328, "TZone-17016");
            InventoryBox c329 = new InventoryBox(329, "Trace-4");
            InventoryBox c330 = new InventoryBox(330, "Trace2 - 21016");
            InventoryBox c331 = new InventoryBox(331, "TW16G-Black");
            InventoryBox c332 = new InventoryBox(332, "WedgeAnc-38-214");
            InventoryBox c333 = new InventoryBox(333, "SW18GA");
            InventoryBox c334 = new InventoryBox(334, "110075");
            InventoryBox c335 = new InventoryBox(335, "BW-12-2");
            InventoryBox c336 = new InventoryBox(336, "BW-12-212");
            InventoryBox c337 = new InventoryBox(337, "BW-12-3");
            InventoryBox c338 = new InventoryBox(338, "Drop-in-12");
            InventoryBox c339 = new InventoryBox(339, "Copper");
            InventoryBox c340 = new InventoryBox(340, "TB18-4");
            InventoryBox c341 = new InventoryBox(341, "TBTo18");
            InventoryBox c342 = new InventoryBox(342, "TB14-4");
            InventoryBox c343 = new InventoryBox(343, "TBTo14");
            InventoryBox c344 = new InventoryBox(344, "TBTo316");

            comboInventory.Items.Add(c1);
            comboInventory.Items.Add(c2);
            comboInventory.Items.Add(c3);
            comboInventory.Items.Add(c4);
            comboInventory.Items.Add(c5);
            comboInventory.Items.Add(c6);
            comboInventory.Items.Add(c7);
            comboInventory.Items.Add(c8);
            comboInventory.Items.Add(c9);
            comboInventory.Items.Add(c10);
            comboInventory.Items.Add(c11);
            comboInventory.Items.Add(c12);
            comboInventory.Items.Add(c13);
            comboInventory.Items.Add(c14);
            comboInventory.Items.Add(c15);
            comboInventory.Items.Add(c16);
            comboInventory.Items.Add(c17);
            comboInventory.Items.Add(c18);
            comboInventory.Items.Add(c19);
            comboInventory.Items.Add(c20);
            comboInventory.Items.Add(c21);
            comboInventory.Items.Add(c22);
            comboInventory.Items.Add(c23);
            comboInventory.Items.Add(c24);
            comboInventory.Items.Add(c25);
            comboInventory.Items.Add(c26);
            comboInventory.Items.Add(c27);
            comboInventory.Items.Add(c28);
            comboInventory.Items.Add(c29);
            comboInventory.Items.Add(c30);
            comboInventory.Items.Add(c31);
            comboInventory.Items.Add(c32);
            comboInventory.Items.Add(c33);
            comboInventory.Items.Add(c34);
            comboInventory.Items.Add(c35);
            comboInventory.Items.Add(c36);
            comboInventory.Items.Add(c37);
            comboInventory.Items.Add(c38);
            comboInventory.Items.Add(c39);
            comboInventory.Items.Add(c40);
            comboInventory.Items.Add(c41);
            comboInventory.Items.Add(c42);
            comboInventory.Items.Add(c43);
            comboInventory.Items.Add(c44);
            comboInventory.Items.Add(c45);
            comboInventory.Items.Add(c46);
            comboInventory.Items.Add(c47);
            comboInventory.Items.Add(c48);
            comboInventory.Items.Add(c49);
            comboInventory.Items.Add(c50);
            comboInventory.Items.Add(c51);
            comboInventory.Items.Add(c52);
            comboInventory.Items.Add(c53);
            comboInventory.Items.Add(c54);
            comboInventory.Items.Add(c55);
            comboInventory.Items.Add(c56);
            comboInventory.Items.Add(c57);
            comboInventory.Items.Add(c58);
            comboInventory.Items.Add(c59);
            comboInventory.Items.Add(c60);
            comboInventory.Items.Add(c61);
            comboInventory.Items.Add(c62);
            comboInventory.Items.Add(c63);
            comboInventory.Items.Add(c64);
            comboInventory.Items.Add(c65);
            comboInventory.Items.Add(c66);
            comboInventory.Items.Add(c67);
            comboInventory.Items.Add(c68);
            comboInventory.Items.Add(c69);
            comboInventory.Items.Add(c70);
            comboInventory.Items.Add(c71);
            comboInventory.Items.Add(c72);
            comboInventory.Items.Add(c73);
            comboInventory.Items.Add(c74);
            comboInventory.Items.Add(c75);
            comboInventory.Items.Add(c76);
            comboInventory.Items.Add(c77);
            comboInventory.Items.Add(c78);
            comboInventory.Items.Add(c79);
            comboInventory.Items.Add(c80);
            comboInventory.Items.Add(c81);
            comboInventory.Items.Add(c82);
            comboInventory.Items.Add(c83);
            comboInventory.Items.Add(c84);
            comboInventory.Items.Add(c85);
            comboInventory.Items.Add(c86);
            comboInventory.Items.Add(c87);
            comboInventory.Items.Add(c89);
            comboInventory.Items.Add(c90);
            comboInventory.Items.Add(c91);
            comboInventory.Items.Add(c92);
            comboInventory.Items.Add(c93);
            comboInventory.Items.Add(c94);
            comboInventory.Items.Add(c95);
            comboInventory.Items.Add(c96);
            comboInventory.Items.Add(c97);
            comboInventory.Items.Add(c98);
            comboInventory.Items.Add(c99);
            comboInventory.Items.Add(c100);
            comboInventory.Items.Add(c101);
            comboInventory.Items.Add(c102);
            comboInventory.Items.Add(c103);
            comboInventory.Items.Add(c104);
            comboInventory.Items.Add(c105);
            comboInventory.Items.Add(c106);
            comboInventory.Items.Add(c107);
            comboInventory.Items.Add(c108);
            comboInventory.Items.Add(c109);
            comboInventory.Items.Add(c110);
            comboInventory.Items.Add(c111);
            comboInventory.Items.Add(c113);
            comboInventory.Items.Add(c114);
            comboInventory.Items.Add(c115);
            comboInventory.Items.Add(c116);
            comboInventory.Items.Add(c117);
            comboInventory.Items.Add(c118);
            comboInventory.Items.Add(c119);
            comboInventory.Items.Add(c120);
            comboInventory.Items.Add(c121);
            comboInventory.Items.Add(c122);
            comboInventory.Items.Add(c123);
            comboInventory.Items.Add(c124);
            comboInventory.Items.Add(c125);
            comboInventory.Items.Add(c126);
            comboInventory.Items.Add(c127);
            comboInventory.Items.Add(c128);
            comboInventory.Items.Add(c129);
            comboInventory.Items.Add(c130);
            comboInventory.Items.Add(c131);
            comboInventory.Items.Add(c132);
            comboInventory.Items.Add(c133);
            comboInventory.Items.Add(c134);
            comboInventory.Items.Add(c135);
            comboInventory.Items.Add(c136);
            comboInventory.Items.Add(c137);
            comboInventory.Items.Add(c138);
            comboInventory.Items.Add(c139);
            comboInventory.Items.Add(c140);
            comboInventory.Items.Add(c141);
            comboInventory.Items.Add(c142);
            comboInventory.Items.Add(c143);
            comboInventory.Items.Add(c144);
            comboInventory.Items.Add(c145);
            comboInventory.Items.Add(c146);
            comboInventory.Items.Add(c147);
            comboInventory.Items.Add(c148);
            comboInventory.Items.Add(c149);
            comboInventory.Items.Add(c150);
            comboInventory.Items.Add(c151);
            comboInventory.Items.Add(c152);
            comboInventory.Items.Add(c153);
            comboInventory.Items.Add(c154);
            comboInventory.Items.Add(c156);
            comboInventory.Items.Add(c157);
            comboInventory.Items.Add(c158);
            comboInventory.Items.Add(c159);
            comboInventory.Items.Add(c160);
            comboInventory.Items.Add(c161);
            comboInventory.Items.Add(c162);
            comboInventory.Items.Add(c163);
            comboInventory.Items.Add(c164);
            comboInventory.Items.Add(c166);
            comboInventory.Items.Add(c167);
            comboInventory.Items.Add(c169);
            comboInventory.Items.Add(c170);
            comboInventory.Items.Add(c170);
            comboInventory.Items.Add(c171);
            comboInventory.Items.Add(c172);
            comboInventory.Items.Add(c173);
            comboInventory.Items.Add(c174);
            comboInventory.Items.Add(c175);
            comboInventory.Items.Add(c176);
            comboInventory.Items.Add(c177);
            comboInventory.Items.Add(c178);
            comboInventory.Items.Add(c179);
            comboInventory.Items.Add(c182);
            comboInventory.Items.Add(c183);
            comboInventory.Items.Add(c184);
            comboInventory.Items.Add(c185);
            comboInventory.Items.Add(c186);
            comboInventory.Items.Add(c187);
            comboInventory.Items.Add(c188);
            comboInventory.Items.Add(c189);
            comboInventory.Items.Add(c190);
            comboInventory.Items.Add(c191);
            comboInventory.Items.Add(c192);
            comboInventory.Items.Add(c193);
            comboInventory.Items.Add(c194);
            comboInventory.Items.Add(c195);
            comboInventory.Items.Add(c196);
            comboInventory.Items.Add(c197);
            comboInventory.Items.Add(c198);
            comboInventory.Items.Add(c199);
            comboInventory.Items.Add(c202);
            comboInventory.Items.Add(c203);
            comboInventory.Items.Add(c204);
            comboInventory.Items.Add(c205);
            comboInventory.Items.Add(c206);
            comboInventory.Items.Add(c207);
            comboInventory.Items.Add(c208);
            comboInventory.Items.Add(c209);
            comboInventory.Items.Add(c210);
            comboInventory.Items.Add(c211);
            comboInventory.Items.Add(c212);
            comboInventory.Items.Add(c213);
            comboInventory.Items.Add(c214);
            comboInventory.Items.Add(c215);
            comboInventory.Items.Add(c216);
            comboInventory.Items.Add(c217);
            comboInventory.Items.Add(c218);
            comboInventory.Items.Add(c219);
            comboInventory.Items.Add(c220);
            comboInventory.Items.Add(c221);
            comboInventory.Items.Add(c222);
            comboInventory.Items.Add(c223);
            comboInventory.Items.Add(c224);
            comboInventory.Items.Add(c225);
            comboInventory.Items.Add(c227);
            comboInventory.Items.Add(c228);
            comboInventory.Items.Add(c229);
            comboInventory.Items.Add(c230);
            comboInventory.Items.Add(c231);
            comboInventory.Items.Add(c232);
            comboInventory.Items.Add(c233);
            comboInventory.Items.Add(c234);
            comboInventory.Items.Add(c236);
            comboInventory.Items.Add(c237);
            comboInventory.Items.Add(c238);
            comboInventory.Items.Add(c239);
            comboInventory.Items.Add(c240);
            comboInventory.Items.Add(c241);
            comboInventory.Items.Add(c242);
            comboInventory.Items.Add(c243);
            comboInventory.Items.Add(c244);
            comboInventory.Items.Add(c245);
            comboInventory.Items.Add(c246);
            comboInventory.Items.Add(c247);
            comboInventory.Items.Add(c248);
            comboInventory.Items.Add(c249);
            comboInventory.Items.Add(c250);
            comboInventory.Items.Add(c251);
            comboInventory.Items.Add(c252);
            comboInventory.Items.Add(c253);
            comboInventory.Items.Add(c254);
            comboInventory.Items.Add(c255);
            comboInventory.Items.Add(c256);
            comboInventory.Items.Add(c257);
            comboInventory.Items.Add(c258);
            comboInventory.Items.Add(c259);
            comboInventory.Items.Add(c260);
            comboInventory.Items.Add(c261);
            comboInventory.Items.Add(c262);
            comboInventory.Items.Add(c263);
            comboInventory.Items.Add(c264);
            comboInventory.Items.Add(c265);
            comboInventory.Items.Add(c266);
            comboInventory.Items.Add(c267);
            comboInventory.Items.Add(c267);
            comboInventory.Items.Add(c268);
            comboInventory.Items.Add(c269);
            comboInventory.Items.Add(c270);
            comboInventory.Items.Add(c271);
            comboInventory.Items.Add(c272);
            comboInventory.Items.Add(c273);
            comboInventory.Items.Add(c274);
            comboInventory.Items.Add(c275);
            comboInventory.Items.Add(c276);
            comboInventory.Items.Add(c277);
            comboInventory.Items.Add(c278);
            comboInventory.Items.Add(c279);
            comboInventory.Items.Add(c280);
            comboInventory.Items.Add(c281);
            comboInventory.Items.Add(c282);
            comboInventory.Items.Add(c283);
            comboInventory.Items.Add(c284);
            comboInventory.Items.Add(c285);
            comboInventory.Items.Add(c286);
            comboInventory.Items.Add(c287);
            comboInventory.Items.Add(c288);
            comboInventory.Items.Add(c289);
            comboInventory.Items.Add(c290);
            comboInventory.Items.Add(c291);
            comboInventory.Items.Add(c292);
            comboInventory.Items.Add(c293);
            comboInventory.Items.Add(c294);
            comboInventory.Items.Add(c295);
            comboInventory.Items.Add(c296);
            comboInventory.Items.Add(c297);
            comboInventory.Items.Add(c298);
            comboInventory.Items.Add(c299);
            comboInventory.Items.Add(c300);
            comboInventory.Items.Add(c301);
            comboInventory.Items.Add(c302);
            comboInventory.Items.Add(c303);
            comboInventory.Items.Add(c304);
            comboInventory.Items.Add(c305);
            comboInventory.Items.Add(c306);
            comboInventory.Items.Add(c307);
            comboInventory.Items.Add(c308);
            comboInventory.Items.Add(c309);
            comboInventory.Items.Add(c310);
            comboInventory.Items.Add(c311);
            comboInventory.Items.Add(c312);
            comboInventory.Items.Add(c313);
            comboInventory.Items.Add(c314);
            comboInventory.Items.Add(c315);
            comboInventory.Items.Add(c316);
            comboInventory.Items.Add(c317);
            comboInventory.Items.Add(c318);
            comboInventory.Items.Add(c319);
            comboInventory.Items.Add(c320);
            comboInventory.Items.Add(c321);
            comboInventory.Items.Add(c322);
            comboInventory.Items.Add(c323);
            comboInventory.Items.Add(c324);
            comboInventory.Items.Add(c325);
            comboInventory.Items.Add(c326);
            comboInventory.Items.Add(c327);
            comboInventory.Items.Add(c328);
            comboInventory.Items.Add(c329);
            comboInventory.Items.Add(c330);
            comboInventory.Items.Add(c331);
            comboInventory.Items.Add(c332);
            comboInventory.Items.Add(c333);
            comboInventory.Items.Add(c334);
            comboInventory.Items.Add(c335);
            comboInventory.Items.Add(c336);
            comboInventory.Items.Add(c337);
            comboInventory.Items.Add(c338);
            comboInventory.Items.Add(c339);
            comboInventory.Items.Add(c340);
            comboInventory.Items.Add(c341);
            comboInventory.Items.Add(c342);
            comboInventory.Items.Add(c343);
            comboInventory.Items.Add(c344);
        }

        public class InventoryModel
        {
            public string name;
            public string description;
            public int quantity;
            public float cost;
            public float totalCost;
            public int productID;
        }
        
        public class KitModel
        {
            public string name;
            public int quantity;
            public decimal salesPrice;
            public decimal unitCost;
            public int kitID;
        }

        public void editRichTextBox(string prodName)
        {
            using (var DB = new CamcoEntities())
            {
                Inventory result = DB.Inventories.SingleOrDefault(x => x.ProductName == prodName);
                

                if (result != null)
                {  
                    /* if statement for kits here*/

                    var text = "Quantity: " + result.ProductQuantity.ToString() + Environment.NewLine + "Unit Cost: " + result.UnitCost.ToString() + Environment.NewLine + "Sales Price: " + result.SalesPrice.ToString();
                    richTextBoxInventory.Text = text;
                }

            }
        }

        private void btnBillOfMaterials_Click(object sender, EventArgs e)
        {
            var newForm = new BillOfMaterialsForm();
            newForm.Show();
        }

        private void btnWorkOrder_Click(object sender, EventArgs e)
        {
            var newForm = new WorkOrderForm();
            newForm.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            var newForm = new NewProductForm();
            newForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inventoryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            var newForm = new DeleteProductForm();
            newForm.Show();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            var newForm = new EditProductForm();
            newForm.Show();
        }

        private void dataGridViewInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void inventoryBindingSource4_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            editRichTextBox(comboInventory.Text);
        }

        private void richTextBoxInventory_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }
    }
}
