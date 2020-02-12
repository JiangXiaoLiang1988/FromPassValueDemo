using System;
using System.Windows.Forms;

namespace DelegateDemo
{
    public partial class frmChild : Form
    {
        public frmChild()
        {
            InitializeComponent();
        }

        // 定义一个公共属性，接收传递的值
        //public string strMessage { get; set; }

        // 定义属性为private
        private string strMessage { get; set; }

        /// <summary>
        /// 给私有属性赋值
        /// </summary>
        /// <param name="strText"></param>
        public void SetText(string strText)
        {
            strMessage = strText;
        }

        /// <summary>
        /// 给控件赋值的方法
        /// </summary>
        /// <param name="strValue"></param>
        public void SetValue(string strValue)
        {
            this.lblMessage.Text = strValue;
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmChild_Load(object sender, EventArgs e)
        {
            // 将接收到的值显示在窗体上
            // this.lblMessage.Text = strMessage;
        }
    }
}
