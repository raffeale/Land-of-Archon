
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class hv_CarpentryShopAddonAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1205, -5, 5, 1}, {1205, -5, -4, 1}, {1205, -5, -3, 1}// 1	2	3	
			, {1205, -5, -2, 1}, {1205, -5, -1, 1}, {1205, -5, 0, 1}// 4	5	6	
			, {1205, -5, 1, 1}, {1205, -5, 2, 1}, {1205, -5, 3, 1}// 7	8	9	
			, {1205, -5, 4, 1}, {7, -5, -5, 1}, {8, -6, -4, 1}// 10	11	12	
			, {8, -6, -3, 1}, {8, -6, -2, 1}, {8, -6, -1, 1}// 13	14	15	
			, {8, -6, 0, 1}, {8, -6, 1, 1}, {8, -6, 2, 1}// 16	17	18	
			, {8, -6, 3, 1}, {8, -6, 4, 1}, {8, -6, 5, 1}// 19	20	21	
			, {7, -5, 5, 1}, {3645, -5, -4, 1}, {3645, -5, -3, 1}// 22	23	24	
			, {3645, -5, 0, 1}, {3647, -5, -3, 4}, {3647, -5, -4, 4}// 25	26	27	
			, {3647, -5, 0, 4}, {3647, -5, -3, 7}, {3647, -5, -2, 1}// 28	29	30	
			, {2473, -5, 0, 7}, {2473, -5, -3, 10}, {2473, -5, -4, 7}// 31	32	33	
			, {1205, -4, 4, 1}, {1205, -4, 5, 1}, {1205, -3, 4, 1}// 34	35	36	
			, {1205, -3, 5, 1}, {1205, -2, 4, 1}, {1205, -2, 5, 1}// 37	38	39	
			, {1205, -1, 4, 1}, {1205, -1, 5, 1}, {1205, 0, 4, 1}// 40	41	42	
			, {1205, 0, 5, 1}, {1205, 1, 4, 1}, {1205, 1, 5, 1}// 43	44	45	
			, {1205, 2, 4, 1}, {1205, 2, 5, 1}, {1205, 3, 4, 1}// 46	47	48	
			, {1205, 3, 5, 1}, {1205, 4, 4, 1}, {1205, 4, 5, 1}// 49	50	51	
			, {1205, 5, 4, 1}, {1205, 5, 5, 1}, {1205, 6, 4, 1}// 52	53	54	
			, {1205, 6, 5, 1}, {1205, -4, -4, 1}, {1205, -4, -3, 1}// 55	56	57	
			, {1205, -4, -2, 1}, {1205, -4, -1, 1}, {1205, -4, 0, 1}// 58	59	60	
			, {1205, -4, 1, 1}, {1205, -4, 2, 1}, {1205, -4, 3, 1}// 61	62	63	
			, {1205, -3, -4, 1}, {1205, -3, -3, 1}, {1205, -3, -2, 1}// 64	65	66	
			, {1205, -3, -1, 1}, {1205, -3, 0, 1}, {1205, -3, 1, 1}// 67	68	69	
			, {1205, -3, 2, 1}, {1205, -3, 3, 1}, {1205, -2, -4, 1}// 70	71	72	
			, {1205, -2, -3, 1}, {1205, -2, -2, 1}, {1205, -2, -1, 1}// 73	74	75	
			, {1205, -2, 0, 1}, {1205, -2, 1, 1}, {1205, -2, 2, 1}// 76	77	78	
			, {1205, -2, 3, 1}, {1205, -1, -4, 1}, {1205, -1, -3, 1}// 79	80	81	
			, {1205, -1, -2, 1}, {1205, -1, -1, 1}, {1205, -1, 0, 1}// 82	83	84	
			, {1205, -1, 1, 1}, {1205, -1, 2, 1}, {1205, -1, 3, 1}// 85	86	87	
			, {1205, 0, -4, 1}, {1205, 0, -3, 1}, {1205, 0, -2, 1}// 88	89	90	
			, {1205, 0, -1, 1}, {1205, 0, 0, 1}, {1205, 0, 1, 1}// 91	92	93	
			, {1205, 0, 2, 1}, {1205, 0, 3, 1}, {1205, 1, -4, 1}// 94	95	96	
			, {1205, 1, -3, 1}, {1205, 1, -2, 1}, {1205, 1, -1, 1}// 97	98	99	
			, {1205, 1, 0, 1}, {1205, 1, 1, 1}, {1205, 1, 2, 1}// 100	101	102	
			, {1205, 1, 3, 1}, {1205, 2, -4, 1}, {1205, 2, -3, 1}// 103	104	105	
			, {1205, 2, -2, 1}, {1205, 2, -1, 1}, {1205, 2, 0, 1}// 106	107	108	
			, {1205, 2, 1, 1}, {1205, 2, 2, 1}, {1205, 2, 3, 1}// 109	110	111	
			, {1205, 3, -4, 1}, {1205, 3, -3, 1}, {1205, 3, -2, 1}// 112	113	114	
			, {1205, 3, -1, 1}, {1205, 3, 0, 1}, {1205, 3, 1, 1}// 115	116	117	
			, {1205, 3, 2, 1}, {1205, 3, 3, 1}, {1205, 4, -4, 1}// 118	119	120	
			, {1205, 4, -3, 1}, {1205, 4, -2, 1}, {1205, 4, -1, 1}// 121	122	123	
			, {1205, 4, 0, 1}, {1205, 4, 1, 1}, {1205, 4, 2, 1}// 124	125	126	
			, {1205, 4, 3, 1}, {1205, 5, -4, 1}, {1205, 5, -3, 1}// 127	128	129	
			, {1205, 5, -2, 1}, {1205, 5, -1, 1}, {1205, 5, 0, 1}// 130	131	132	
			, {1205, 5, 1, 1}, {1205, 5, 2, 1}, {1205, 5, 3, 1}// 133	134	135	
			, {1205, 6, -4, 1}, {1205, 6, -3, 1}, {1205, 6, -2, 1}// 136	137	138	
			, {1205, 6, -1, 1}, {1205, 6, 0, 1}, {1205, 6, 1, 1}// 139	140	141	
			, {1205, 6, 2, 1}, {1205, 6, 3, 1}, {6647, -3, -3, 1}// 142	143	144	
			, {6646, -2, -3, 1}, {4152, -3, -2, 2}, {4152, -3, -3, 1}// 145	146	147	
			, {4152, -3, -2, 1}, {4152, -2, -3, 1}, {4152, -2, -2, 1}// 148	149	150	
			, {4152, -1, -3, 1}, {4152, -1, -2, 1}, {4152, 0, -3, 1}// 151	152	153	
			, {4152, 0, -2, 1}, {7793, 1, -3, 1}, {7801, -2, -3, 5}// 154	155	156	
			, {7801, 2, -3, 1}, {7790, 0, -3, 1}, {4152, -3, -1, 1}// 157	158	159	
			, {4152, -3, 0, 1}, {4152, -3, 1, 1}, {4152, -2, -1, 1}// 160	161	162	
			, {4152, -2, 0, 1}, {4152, -2, 1, 1}, {4152, -1, -1, 1}// 163	164	165	
			, {4152, -1, 0, 1}, {4152, -1, 1, 1}, {4152, 0, -1, 1}// 166	167	168	
			, {4152, 0, 0, 1}, {4152, 0, 1, 1}, {6651, -2, 3, 1}// 169	170	171	
			, {6652, -1, 3, 1}, {6649, 2, 1, 1}, {6650, 2, 0, 1}// 172	173	174	
			, {7129, 1, 3, 0}, {7134, 2, 2, 1}, {6645, -1, -3, 1}// 175	176	177	
			, {4152, -4, -3, 2}, {4152, -4, -2, 1}, {7799, -4, -3, 1}// 178	179	180	
			, {6643, -4, -2, 1}, {4152, -4, -1, 1}, {4152, -4, 0, 1}// 181	182	183	
			, {4152, -4, 1, 1}, {7806, -4, 3, 1}, {7799, -4, 3, 1}// 184	185	186	
			, {7799, -4, 1, 1}, {6642, -4, -1, 1}, {6641, -4, 0, 1}// 187	188	189	
			, {6, 6, 5, 1}, {7, -4, 5, 1}, {7, -3, 5, 1}// 190	191	192	
			, {7, -2, 5, 1}, {7, -1, 5, 1}, {7, 0, 5, 1}// 193	194	195	
			, {7, 1, 5, 1}, {7, 2, 5, 1}, {7, 3, 5, 1}// 196	197	198	
			, {8, 6, -3, 1}, {8, 6, -2, 1}, {8, 6, -1, 1}// 199	200	201	
			, {8, 6, 0, 1}, {8, 6, 1, 1}, {8, 6, 2, 1}// 202	203	204	
			, {8, 6, 3, 1}, {8, 6, 4, 1}, {7, -4, -5, 1}// 205	206	207	
			, {7, -3, -5, 1}, {7, -2, -5, 1}, {7, -1, -5, 1}// 208	209	210	
			, {7, 0, -5, 1}, {7, 1, -5, 1}, {7, 2, -5, 1}// 211	212	213	
			, {7, 3, -5, 1}, {7, 4, -5, 1}, {7, 5, -5, 1}// 214	215	216	
			, {7, 6, -5, 1}, {8, 6, -4, 1}, {3645, -4, -4, 1}// 217	218	219	
			, {3647, -4, -4, 4}, {7, 4, 5, 1}, {2970, 3, 6, 1}// 220	221	222	
			, {2992, 3, 6, 1}// 223	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new hv_CarpentryShopAddonAddonDeed();
			}
		}

		[ Constructable ]
		public hv_CarpentryShopAddonAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


		}

		public hv_CarpentryShopAddonAddon( Serial serial ) : base( serial )
		{
		}


		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class hv_CarpentryShopAddonAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new hv_CarpentryShopAddonAddon();
			}
		}

		[Constructable]
		public hv_CarpentryShopAddonAddonDeed()
		{
			Name = "hv_CarpentryShopAddon";
		}

		public hv_CarpentryShopAddonAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}