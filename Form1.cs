using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 天刀金价查询工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*大吉大利，No Bug Please.*/

            /*
             * 服务器列表：（2019-02-14记录）
             * 青龙乱舞（4）：长生剑、孔雀翎、情人箭、多情环
             * 大地飞鹰（2）：凤凰集、藏锋谷
             * 血海飘香（3）：蔷薇、吹雪、弧光
             * 陌上花开（2）：彼岸花、月见草
             * 天命风流（3）：锦鲤抄、千秋月、凤求凰
             * 沧海云帆（8）：时光沧海、青龙永夜、今夕何夕、潜龙之渊、月华流照、幻海花城、天风海雨、天行九歌
             */

            //青龙乱舞
            button1.Text = "长生剑";
            button2.Text = "孔雀翎";
            button3.Text = "情人箭";
            button4.Text = "多情环";
            //大地飞鹰
            button5.Text = "凤凰集";
            button6.Text = "藏锋谷";
            //血海飘香
            button7.Text = "蔷薇";
            button8.Text = "吹雪";
            button9.Text = "弧光";
            //陌上花开
            button10.Text = "彼岸花";
            button11.Text = "月见草";
            //天命风流
            button12.Text = "锦鲤抄";
            button13.Text = "千秋月";
            button14.Text = "凤求凰";
            //沧海云帆
            button15.Text = "时光沧海";
            button16.Text = "青龙永夜";
            button17.Text = "今夕何夕";
            button18.Text = "潜龙之渊";
            button19.Text = "月华流照";
            button20.Text = "幻海花城";
            button21.Text = "天风海雨";
            button22.Text = "天行九歌";

        }

        private void Button_Click(object sender, EventArgs e)
        {
            /*
             * 按钮的信息存储在sender中
             * object可以存储任何类型的变量
             * 需要先将sender转换为Button类型再调用其中内容
             */
            Button ClickTitle = (Button)sender;
            Text = ClickTitle.Text;//Button_Click事件会重复触发，在这里就可以直接解决
            switch (ClickTitle.Text)
            {
                //青龙乱舞
                case "长生剑":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-z2bd0q-ecxrh1-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-1776-s22490/");
                    break;

                case "孔雀翎":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-z2bd0q-egf0sq-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-1776-s22748/");
                    break;

                case "情人箭":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-z2bd0q-shy5fq-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-1776-s23097/");
                    break;

                case "多情环":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-z2bd0q-ij1xwa-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-1776-s25298/");
                    break;
                //大地飞鹰
                case "凤凰集":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-wshzzs-dshotu-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-2187-s22491/");
                    break;

                case "藏锋谷":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-wshzzs-pntuvf-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-2187-s22749/");
                    break;
                //血海飘香
                case "蔷薇":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-kgzhlz-2gchua-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-2219-s23100/");
                    break;

                case "吹雪":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-kgzhlz-vmetc2-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-2219-s29654/");
                    break;

                case "弧光":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-kgzhlz-4cklcc-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-2219-s29651/");
                    break;
                //陌上花开
                case "彼岸花":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-amue5z-vd5ynz-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-2239-s23285/");
                    break;

                case "月见草":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-amue5z-uncojn-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-2239-s23300/");
                    break;
                //天命风流
                case "锦鲤抄":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-qx0r3q-fqppyu-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-2424-s25761/");
                    break;

                case "千秋月":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-qx0r3q-d0mm1s-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-2424-s25763/");
                    break;

                case "凤求凰":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-qx0r3q-qza5or-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-2424-s27705/");
                    break;
                //沧海云帆
                case "时光沧海":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-ttarod-g4v5qv-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-2817-s30259/");
                    break;

                case "青龙永夜":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-ttarod-ckztg3-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-2817-s30260/");
                    break;

                case "今夕何夕":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-ttarod-54014u-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-2817-s30457/");
                    break;

                case "潜龙之渊":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-ttarod-4i4mfe-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-2817-s30890/");
                    break;

                case "月华流照":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-ttarod-m4iflc-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-2817-s30984/");
                    break;

                case "幻海花城":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-ttarod-1vhsbu-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-2817-s31715/");
                    break;

                case "天风海雨":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-ttarod-tqbljz-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-2817-s31985/");
                    break;

                case "天行九歌":
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    webBrowser1.Navigate("http://s.5173.com/wuxia-xptjnl-ttarod-bbo0t1-0-bfg1k1-0-0-0-a-a-a-a-a-0-0-0-0.shtml");
                    webBrowser2.Navigate("http://www.uu898.com/newTrade-217-c-3-2817-s32491/");
                    break;
                //默认case，弹出报错
                default:
                    tabControl2.SelectedTab = tabControl2.TabPages[0];
                    MessageBox.Show("传入了错误信息。");
                    break;

            }


        }
    }
}
