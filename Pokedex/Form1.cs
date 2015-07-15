using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class Form1 : Form
    {
        private int index1 = 18;
        private int index2 = 18;
        private List<PictureBox> list4x;
        private List<PictureBox> list2x;
        private List<PictureBox> listNeutral;
        private List<PictureBox> listHalf;
        private List<PictureBox> listQuarter;
        private List<PictureBox> listImmune;


        private double[,] typeChart = new double[19, 19]
        {
            {1, 1, 1, 1 , 1, .5 , 2, 2, 1, .5, .5, 1, 1, 1, 1, 2, 1, 1, 1 },
            {2, .5, 1, 1, 2, 2, 1, 1, .5, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 },
            {1, 1, 2, .5, 2, 1, .5, 1, 1, .5, 1, 2, 1, 1, 1, 1, 1, .5, 1 },
            {1, 1, 1, .5, 1, 1, 1, .5, 1, 1, 2, 1, 1, 1, 1, 1, .5, 1, 1 },
            {.5, .5, 0, 1, 1, .5, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 2, 1, 1 },
            {.5, .5, 1, 1, 2, 1, 1, 2, 1, 1, 1, 1, 1, 1, 2, .5, 1, 1, 1 },
            {.5, 1, 1, 1, .5, 1, .5, 1, 1, .5, 2, .5, 1, 1, 1, 2, .5, 2, 1 },
            {.5, 1, 1, 2, 1, .5, 1, 1, 1, .5, 0, 2, 1, 1, 1, 2, 1, 1, 1 },
            {.5, 2, 1, 1, 1, 0, 1, 1, 2, 1, 1, 1, 0, .5, 1, 1, 1, 1, 1 },
            {2, 1, 1, .5, 1, 1, 2, 2, 1, .5, .5, 2, 1, 2, 1, 1, 1, .5, 1 },
            {1, 1, 1, 0, 1, 1, 1 , 1, 1, 2, 1, 2, 1, .5, 1, .5, 1, 2, 1 },
            { 1, 1, 1, 1, 1, 2, 2, 1, 1, 1, 1, .5, 1, 1, 1, 2, 2, 1, 1 },
            {1, 1, 1, 1, 1, 2, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            {.5, 1, 1, 1, .5, .5, 1, 1, 1, .5, 2, 1, 1, .5, 2, 1, 1, 1, 1 },
            {2, 2, 1, 1, 1, .5, 1, 1, 2, 1, 1, 1, 1, 1, .5, 1, 1, 1, 1 },
            {1, 1, 1, 1, 1, 2, .5, .5, 1, 2, 2, 1, 1, 1, 1, 1, 2, 2, 1 },
            {.5, 1, .5, 1, .5, 2, 2, .5, 1, .5, 2, .5, .5, 0, .5, .5, .5, 1, 1 },
            {1, 1, 1, 2, 1, 1, .5, 1, 1, 2, 1, .5, 1, 1, 1, 1, .5, .5, 1 },
            {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }

        };
        private Dictionary<String, int> typeDict = new Dictionary<String, int>
        {
            {"bug", 0 },
            {"dark", 1},
            {"dragon", 2 },
            {"electric", 3 },
            {"fairy", 4 },
            {"fighting", 5 },
            {"fire", 6 },
            {"flying", 7 },
            {"ghost", 8 },
            {"grass", 9 },
            {"ground", 10 },
            {"ice", 11 },
            {"normal", 12 },
            {"poison", 13 },
            {"psychic", 14 },
            {"rock", 15 },
            {"steel", 16 },
            {"water",17 },
            {"unknown", 18 }
        };
        public Form1()
        {
            InitializeComponent();
            list4x = new List<PictureBox> { weak4x0, weak4x1, weak4x2,weak4x3,weak4x4,weak4x5,
                            weak4x6,weak4x7,weak4x8,weak4x9,weak4x10,weak4x11,weak4x12,
                            weak4x13, weak4x14, weak4x15, weak4x16, weak4x17};

            list2x = new List<PictureBox>
            {
                weak2x0, weak2x1, weak2x2, weak2x3, weak2x4, weak2x5, weak2x6, weak2x7, weak2x8,
                weak2x9, weak2x10, weak2x11, weak2x12, weak2x13, weak2x14, weak2x15, weak2x16,
                weak2x17
            };

            listNeutral = new List<PictureBox>
            {
                neutralx0, neutralx1, neutralx2, neutralx3, neutralx4, neutralx5, neutralx6,
                neutralx7, neutralx8, neutralx9, neutralx10, neutralx11, neutralx12, neutralx13,
                neutralx14, neutralx15, neutralx16, neutralx17
            };

            listHalf = new List<PictureBox>
            {
                weakHalfx0, weakHalfx1, weakHalfx2, weakHalfx3, weakHalfx4, weakHalfx5,
                weakHalfx6, weakHalfx7, weakHalfx8, weakHalfx9, weakHalfx10, weakHalfx11,
                weakHalfx12, weakHalfx13, weakHalfx14, weakHalfx15, weakHalfx16, weakHalfx17

            };

            listQuarter = new List<PictureBox>
            {
                weakQuarterx0, weakQuarterx1, weakQuarterx2, weakQuarterx3, weakQuarterx4,
                weakQuarterx5, weakQuarterx6, weakQuarterx7, weakQuarterx8, weakQuarterx9,
                weakQuarterx10, weakQuarterx11, weakQuarterx12, weakQuarterx13, weakQuarterx14,
                weakQuarterx15, weakQuarterx16, weakQuarterx17
            };

            listImmune = new List<PictureBox>
            {
                immunex0, immunex1, immunex2, immunex3, immunex4, immunex5
            };
            index1 = 18;
            index2 = 18;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void firstType_TextChanged(object sender, EventArgs e)
        {
            onTextChange();

            string s = "";


            if (firstType.Text == "")
            {
                firstTypePicture.Image = imageList1.Images[18];
                index1 = 18;
                return;
            }
            foreach (var kv in typeDict)
            {
                if (kv.Key.StartsWith(firstType.Text.ToLower()))
                {
                    s = kv.Key;
                    break;
                }
            }

            int index;
            if (typeDict.TryGetValue(s, out index1))
            {
                firstTypePicture.Image = imageList1.Images[index1];
                Console.WriteLine(index1);
            }
            else
            {
                firstTypePicture.Image = imageList1.Images[18];
            }

            onTextChange();
        




        }

        private void secondType_TextChanged(object sender, EventArgs e)
        {
            onTextChange();

            string s = "";


            if(secondType.Text == "")
            {
                secondTypePicture.Image = imageList1.Images[18];
                index2 = 18;
                return;
            }
            foreach(var kv in typeDict)
            {
                if(kv.Key.StartsWith(secondType.Text.ToLower()))
                {
                    s = kv.Key;
                    break;
                }
            }
    
            int index;
            if (typeDict.TryGetValue(s, out index2))
            {
                secondTypePicture.Image = imageList1.Images[index2];
            }
            else
            {
                secondTypePicture.Image = imageList1.Images[18];
            }

            onTextChange();

        }

        private void onTextChange()
        {
            typeResults.Text = firstType.Text + "/" + secondType.Text;


            ArrayList weak4 = new ArrayList();
            ArrayList weak2 = new ArrayList();
            ArrayList neutral = new ArrayList();
            ArrayList weakHalf = new ArrayList();
            ArrayList weakQuarter = new ArrayList();
            ArrayList Immune = new ArrayList();


            for (int i = 0; i < 18; i++)
            {
                list4x[i].Image = null;
                list2x[i].Image = null;
                listNeutral[i].Image = null;
                listHalf[i].Image = null;
                listQuarter[i].Image = null;
             
            }

            for (int i = 0; i < 6; i++)
                listImmune[i].Image = null;




            for (int i = 0; i < 18; i++)
            {
                double result = typeChart[index1, i] * typeChart[index2, i];

                if (result == 4.0)
                {
                    weak4.Add(i);
                }
                else if (result == 2.0)
                {
                    weak2.Add(i);
                }
                else if (result == 1.0)
                {
                    neutral.Add(i);
                }
                else if (result == .5)
                {
                    weakHalf.Add(i);
                }
                else if (result == .25)
                {
                    weakQuarter.Add(i);
                }
                else if(result == 0.0)
                {
                    Immune.Add(i);
                }

            }


            for (int i = 0; i < weak4.Count; i++)
            {
                list4x[i].Image = imageList1.Images[(int)weak4[i]];

            }
            for (int i = 0; i < weak2.Count; i++)
            {
                list2x[i].Image = imageList1.Images[(int)weak2[i]];
            }
            for (int i = 0; i < neutral.Count; i++)
            {
                listNeutral[i].Image = imageList1.Images[(int)neutral[i]];
            }
            for (int i = 0; i < weakHalf.Count; i++)
            {
                listHalf[i].Image = imageList1.Images[(int)weakHalf[i]];
            }
            for(int i = 0; i < weakQuarter.Count; i++)
            {
                listQuarter[i].Image = imageList1.Images[(int)weakQuarter[i]];
            }
            for(int i = 0; i < Immune.Count; i++)
            {
                listImmune[i].Image = imageList1.Images[(int)Immune[i]];
            }

        }
    }
}
