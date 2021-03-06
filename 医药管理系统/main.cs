﻿using InventoryManagentSystem;
using InventoryManagentSystem.bean;
using InventoryManagentSystem.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using 医药管理系统.drug;
using 医药管理系统.kucun;
using 医药管理系统.report;
using 医药管理系统.test;

namespace 医药管理系统
{
    public partial class main : Form
    {
        
        List<String> list;
        sale s_17 = new sale();
        sale_Add s_18 = new sale_Add();
        退单管理 s_19 = new 退单管理();
        Good_Del s_20 = new Good_Del();
        addDrug s_10 = new addDrug();
        queryDrug s_9 = new queryDrug();
        Form_InventoryWarning s_15 = new Form_InventoryWarning();
        Form_StockIn s_12 = new Form_StockIn();
        Form_StockOut s_13 = new Form_StockOut();
        Form_StockOutCheck s_16 = new Form_StockOutCheck();
        Form_WarehouseManage s_11 = new Form_WarehouseManage();
        Form_MedicineCheck s_28 = new Form_MedicineCheck();
        Form_MCManage s_100 = new Form_MCManage();
        Form_CustomerManage s_26 = new Form_CustomerManage();
        Form_CustomerAdd s_27 = new Form_CustomerAdd();
        Limits.limitList s_31 = new Limits.limitList();
        Limits.addLimits s_32 = new Limits.addLimits();
        good_sale_delete s_33 = new good_sale_delete();
        Form_StaffManage s_29 = new Form_StaffManage();
        Form_Entry s_30 = new Form_Entry();
        in_report s_21 = new in_report();
        out_reports s_22 = new out_reports();
        sale_manager s_23 = new sale_manager();
        good_ s_24 = new good_();
        public main()
        {
            
            InitializeComponent();
            this.skinEngine1.SkinFile = "MacOS.ssk";
            this.Text = "石家庄市长安福利药化工厂仓库管理系统";
            this.Show();
            this.tabcontrol.CloseButtonClick += new EventHandler(close_click);
            this.advTree1.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(select);
            //this.FormClosing += new FormClosingEventHandler(close_clicked);

        }
        public void select(object o, DevComponents.AdvTree.TreeNodeMouseEventArgs d)
        {
            if (this.advTree1.SelectedNode == this.node34)
            {
                if (MessageBox.Show("是否确定退出？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else if (this.advTree1.SelectedNode == this.node35)
            {
                if (MessageBox.Show("是否确定切换用户？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Login l = new Login();
                    this.Close();
                }
            }
            else if (this.advTree1.SelectedNode == this.node17)
            {
                if (this.tabcontrol.TabPages.Contains(s_17) == false)
                {
                    this.tabcontrol.TabPages.Add(s_17);
                }
                this.tabcontrol.SelectedTabPage = s_17;
            }
            else if (this.advTree1.SelectedNode == this.node21)
            {
                if (this.tabcontrol.TabPages.Contains(s_21) == false)
                {
                    this.tabcontrol.TabPages.Add(s_21);
                }
                this.tabcontrol.SelectedTabPage = s_21;
            }
            else if (this.advTree1.SelectedNode == this.node22)
            {
                if (this.tabcontrol.TabPages.Contains(s_22) == false)
                {
                    this.tabcontrol.TabPages.Add(s_22);
                }
                this.tabcontrol.SelectedTabPage = s_22;
            }
            else if (this.advTree1.SelectedNode == this.node23)
            {
                if (this.tabcontrol.TabPages.Contains(s_23) == false)
                {
                    this.tabcontrol.TabPages.Add(s_23);
                }
                this.tabcontrol.SelectedTabPage = s_23;
            }
            else if (this.advTree1.SelectedNode == this.node24)
            {
                if (this.tabcontrol.TabPages.Contains(s_24) == false)
                {
                    this.tabcontrol.TabPages.Add(s_24);
                }
                this.tabcontrol.SelectedTabPage = s_24;
            }
            else if (this.advTree1.SelectedNode == this.node29)
            {
                if (this.tabcontrol.TabPages.Contains(s_29) == false)
                {
                    this.tabcontrol.TabPages.Add(s_29);
                }
                this.tabcontrol.SelectedTabPage = s_29;
                s_29.re();
               // s_29.InitdataGridView1();
            }
            else if (this.advTree1.SelectedNode == this.node30)
            {
                if (this.tabcontrol.TabPages.Contains(s_30) == false)
                {
                    this.tabcontrol.TabPages.Add(s_30);
                }
                this.tabcontrol.SelectedTabPage = s_30;
                s_30.InitComboBox1();
            }
            else if (this.advTree1.SelectedNode == this.node33)
            {
                if (this.tabcontrol.TabPages.Contains(s_33) == false)
                {
                    this.tabcontrol.TabPages.Add(s_33);
                }
                this.tabcontrol.SelectedTabPage = s_33;
            }
            else if (this.advTree1.SelectedNode == this.node31)
            {
                s_31 = new Limits.limitList();
                if (this.tabcontrol.TabPages.Contains(s_31) == false)
                {
                    this.tabcontrol.TabPages.Add(s_31);
                }
                this.tabcontrol.SelectedTabPage = s_31;
                
            }
            else if (this.advTree1.SelectedNode == this.node32)
            {
                if (this.tabcontrol.TabPages.Contains(s_32) == false)
                {
                    this.tabcontrol.TabPages.Add(s_32);
                }
                this.tabcontrol.SelectedTabPage = s_32;
            }
            else if (this.advTree1.SelectedNode == this.node26)
            {
                if (this.tabcontrol.TabPages.Contains(s_26) == false)
                {
                    this.tabcontrol.TabPages.Add(s_26);
                }
                this.tabcontrol.SelectedTabPage = s_26;
                s_26.InitdataGridView1();
            }
            else if (this.advTree1.SelectedNode == this.node27)
            {
                if (this.tabcontrol.TabPages.Contains(s_27) == false)
                {
                    this.tabcontrol.TabPages.Add(s_27);
                }
                this.tabcontrol.SelectedTabPage = s_27;
            }
            else if (this.advTree1.SelectedNode == this.node18)
            {
                if (this.tabcontrol.TabPages.Contains(s_18) == false)
                {
                    this.tabcontrol.TabPages.Add(s_18);
                }
                this.tabcontrol.SelectedTabPage = s_18;
            }
            else if (this.advTree1.SelectedNode == this.node100)
            {
                if (this.tabcontrol.TabPages.Contains(s_100) == false)
                {
                    this.tabcontrol.TabPages.Add(s_100);
                }
                this.tabcontrol.SelectedTabPage = s_100;
                s_100.InitdataGridView1();
            }
            else if (this.advTree1.SelectedNode == this.node11)
            {
                if (this.tabcontrol.TabPages.Contains(s_11) == false)
                {
                    this.tabcontrol.TabPages.Add(s_11);
                }
                else
                {
                    s_11.initDataGridView1();
                }
                this.tabcontrol.SelectedTabPage = s_11;
               
            }
            else if (this.advTree1.SelectedNode == this.node16)
            {
                if (this.tabcontrol.TabPages.Contains(s_16) == false)
                {
                    this.tabcontrol.TabPages.Add(s_16);
                }
                this.tabcontrol.SelectedTabPage = s_16;
            }
            else if (this.advTree1.SelectedNode == this.node19)
            {
                if (this.tabcontrol.TabPages.Contains(s_19) == false)
                {
                    this.tabcontrol.TabPages.Add(s_19);
                }
                this.tabcontrol.SelectedTabPage = s_19;
            }
            else if (this.advTree1.SelectedNode == this.node13)
            {
                if (this.tabcontrol.TabPages.Contains(s_13) == false)
                {
                    this.tabcontrol.TabPages.Add(s_13);
                }
                this.tabcontrol.SelectedTabPage = s_13;
                s_13.init1();
            }
            else if (this.advTree1.SelectedNode == this.node28)
            {
                if (this.tabcontrol.TabPages.Contains(s_28) == false)
                {
                    this.tabcontrol.TabPages.Add(s_28);
                }
                this.tabcontrol.SelectedTabPage = s_28;
            }
            else if (this.advTree1.SelectedNode == this.node20)
            {
                if (this.tabcontrol.TabPages.Contains(s_20) == false)
                {
                    this.tabcontrol.TabPages.Add(s_20);
                }
                this.tabcontrol.SelectedTabPage = s_20;
            }
            else if (this.advTree1.SelectedNode == this.node10)
            {
                if (this.tabcontrol.TabPages.Contains(s_10) == false)
                {
                    this.tabcontrol.TabPages.Add(s_10);
                }
                this.tabcontrol.SelectedTabPage = s_10;
            }
            else if (this.advTree1.SelectedNode == this.node9)
            {
                if (this.tabcontrol.TabPages.Contains(s_9) == false)
                {
                    this.tabcontrol.TabPages.Add(s_9);
                }
                this.tabcontrol.SelectedTabPage = s_9;
               
            }
            else if (this.advTree1.SelectedNode == this.node15)
            {
                if (this.tabcontrol.TabPages.Contains(s_15) == false)
                {
                    this.tabcontrol.TabPages.Add(s_15);
                }
                this.tabcontrol.SelectedTabPage = s_15;
            }
            else if (this.advTree1.SelectedNode == this.node12)
            {
                if (this.tabcontrol.TabPages.Contains(s_12) == false)
                {
                    this.tabcontrol.TabPages.Add(s_12);
                }
                this.tabcontrol.SelectedTabPage = s_12;
                s_12.InitComboBox2();
            }
        }
        public void close_click(object o, EventArgs e)
        {
            this.tabcontrol.TabPages.Remove(this.tabcontrol.SelectedTabPage);
        }
        protected override void WndProc(ref Message msg)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;
            if (msg.Msg == WM_SYSCOMMAND && ((int)msg.WParam == SC_CLOSE))
            {
                if (MessageBox.Show("是否确定退出？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    
                }
                return;
            }
            base.WndProc(ref msg);
        }

       /* public void close_clicked(Object o, FormClosingEventArgs e)
        {
            if (e.CloseReason==CloseReason.UserClosing)
            {
                if (MessageBox.Show("是否确定退出？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel=true;
                }
            }
        }*/
        private void main_Load(object sender, EventArgs e)
        {

        }

        private void advTree1_Click(object sender, EventArgs e)
        {

        }
    }
}
