﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 医药管理系统
{
    class sql_conn
    {
        public MySqlConnection getconn()
        {
            try
            {
                string M_str_sqlcon = "server=localhost;user id=root;password= ;database=yygl;pooling=false;CharSet=utf8;"; //根据自己的设置
                MySqlConnection myCon = new MySqlConnection(M_str_sqlcon);
                return myCon;
            }
            catch
            {
                MessageBox.Show("数据库连接失败,请检查网络连接");
                Application.Exit(); 
            }
            return null;
        }
    }
}
