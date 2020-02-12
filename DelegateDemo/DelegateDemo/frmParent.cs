using System;
using System.Windows.Forms;

namespace DelegateDemo
{
    
    public partial class frmParent : Form
    {
        // 定义一个有参无返回值的委托
        public delegate void SendMessage(string strMessage);

        // 定义一个委托类型的事件
        public event SendMessage sendMessageEvent;


        public event Action<string> actionEvent;
        public frmParent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Value_Click(object sender, EventArgs e)
        {
            #region 调用公共属性赋值
            //frmChild child = new frmChild();
            //// 给窗体的公共属性赋值
            //child.strMessage = this.txtMessage.Text.Trim();
            //// 显示子窗体
            //child.Show(); 
            #endregion


            #region 调用方法赋值
            //frmChild child = new frmChild();
            //// 给窗体的公共属性赋值
            //child.SetText(this.txtMessage.Text.Trim());
            //// 显示子窗体
            //child.Show(); 
            #endregion

            #region 通过委托传值
            //frmChild child = new frmChild();
            //// 将方法绑定到事件上
            //// sendMessageEvent += new SendMessage(child.SetValue);
            //// 也可以使用下面的简写形式
            //sendMessageEvent += child.SetValue;
            //child.Show();
            #endregion

            #region 使用Action
            frmChild child = new frmChild();
            // 将方法绑定到事件上
            actionEvent += child.SetValue;
            child.Show();
            #endregion

            // 使用自定义委托
            //if (sendMessageEvent!=null)
            //{
            //    sendMessageEvent.Invoke(this.txtMessage.Text.Trim());
            //}

            // 使用Action委托
            if (actionEvent != null)
            {
                actionEvent.Invoke(this.txtMessage.Text.Trim());
            }
        }
    }
}
