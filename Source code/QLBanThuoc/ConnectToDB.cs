using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Xml;

namespace QLBanThuoc.Data
{
    public partial class frmConnection : DevExpress.XtraEditors.XtraForm
    {
        public frmConnection()
        {
            InitializeComponent();
        }

        public static string str = null;
        public static SqlConnection m_Conn = null;
        public static SqlConnection connection = null;
        public static SqlCommand command = new SqlCommand();
        public static SqlDataAdapter adapter = new SqlDataAdapter();
       

        public void FrmConnection_Load(object sender, EventArgs e)
        {
            cmbAuthentication.SelectedItem = "Windows Authentication";
        }

        public void createConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = str;
                    connection.Open();
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
       
    

        public int executeProc(SqlCommand command)
        {
            try
            {
                if (connection.State == 0)
                    createConn();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                return command.ExecuteNonQuery();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message.ToString(), "Error Message");
                return 0;
            }

        }
        public int executeQuery(SqlCommand dbCommend)
        {
            try
            {
                if (connection.State == 0)
                    createConn();
                dbCommend.Connection = connection;
                dbCommend.CommandType = CommandType.Text;
                return dbCommend.ExecuteNonQuery();
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message.ToString(), "Error Message");
                return 0;
            }
        }

        public object ExcuteReadQuery(SqlCommand sqlCommand)
        {
            try
            {
                sqlCommand.Connection = connection;
                return sqlCommand.ExecuteReader();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "ErrorMessage");
                return null;
            }
        }
        public object executeSelectQuery(SqlCommand dbCommend)
        {
            try
            {
                if (connection.State == 0)
                    createConn();
                dbCommend.Connection = connection;
                dbCommend.CommandType = CommandType.Text;
                return dbCommend.ExecuteScalar();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void excuteReaderProc(SqlCommand sql, SqlDataReader dr)
        {
            try
            {
                sql.Connection = connection;
                sql.CommandType = CommandType.StoredProcedure;
                dr = sql.ExecuteReader();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "ErrorMessage");
                
            }
        }
        public void readDataProc(SqlCommand sql, DataTable dt)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    createConn();
                sql.Connection = connection;
                sql.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sql;
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
        public void readDatathroughAdapter(string query, DataTable tblName)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    createConn();
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                adapter = new SqlDataAdapter(command);
                adapter.Fill(tblName);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BtnOK_Click(object sender, EventArgs e)
        {
            if (cmbAuthentication.SelectedItem.Equals("Windows Authentication"))
                XML.XMLWriter("Connection.xml", txtServer.Text, cmbDatabase.Text, "true");
            else
                XML.XMLWriter("Connection.xml", txtServer.Text, txtUsername.Text, txtPassword.Text, cmbDatabase.Text, "false");

            this.DialogResult = DialogResult.OK;
            XtraForm1 frm = new XtraForm1();
            frm.Show();
            this.Hide();
        }

        public void BtnTestConnection_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = XML.XMLReader("Connection.xml");
            XmlElement xmlEle = xmlDoc.DocumentElement;
            //Quyền Windows
            if (cmbAuthentication.SelectedItem.Equals("Windows Authentication"))
            {
                cmbDatabase.Items.Clear();
                m_Conn = new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=master;Integrated Security=True;");
                SqlCommand m_Cmd = new SqlCommand("SP_DATABASES", m_Conn);
                SqlDataReader m_DReader;
                
                try
                {
                    m_Conn.Open();
                    m_DReader = m_Cmd.ExecuteReader();
                    while (m_DReader.Read())
                    {
                        cmbDatabase.Items.Add(m_DReader[0].ToString());
                    }
                    if (String.Compare(txtServer.Text, "") > 0)
                    {
                        MessageBox.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        str = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";Integrated Security=True;";
                        connection = new SqlConnection(str);
                    }
                    else
                        MessageBox.Show("Lỗi kết nối", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message, "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    if (m_Conn.State == ConnectionState.Open)
                        m_Conn.Close();

                    m_Conn.Dispose();
                    m_Cmd.Dispose();
                }
            }

            //Quyền SQL Server
            if (cmbAuthentication.SelectedItem.Equals("SQL Server Authentication"))
            {
                cmbDatabase.Items.Clear();
                m_Conn = new SqlConnection("Data Source=" + txtServer.Text + ";Initial Catalog=master;User Id=" + txtUsername.Text + ";Password=" + txtPassword.Text + ";");
                SqlCommand m_Cmd = new SqlCommand("SP_DATABASES", m_Conn);
                SqlDataReader m_DReader;

                try
                {
                    m_Conn.Open();
                    m_DReader = m_Cmd.ExecuteReader();
                    while (m_DReader.Read())
                    {
                        cmbDatabase.Items.Add(m_DReader[0].ToString());
                    }
                    if (String.Compare(txtServer.Text, "") == 0)
                        MessageBox.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Lỗi kết nối", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message, "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    if (m_Conn.State == ConnectionState.Open)
                        m_Conn.Close();

                    m_Conn.Dispose();
                    m_Cmd.Dispose();
                }
            }
        }
        public void CmbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAuthentication.SelectedItem.Equals("Windows Authentication"))
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }
    }
    public class XML
    {
        public static XmlDocument XMLReader(String filename)
        {
            XmlDocument xmlR = new XmlDocument();
            try
            {
                xmlR.Load(filename);
            }
            catch
            {
                MessageBox.Show("Không đọc được hoặc không tồn tại tập tin cấu hình " + filename, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return xmlR;
        }

        public static void XMLWriter(String filename, String servname, String database, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(filename, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                "Thong so co ban:\n\t" +
                                "costatus = true : quyen Windows\n\t" +
                                "costatus = false: quyen SQL Server\n\t" +
                                "servname: ten server\n\t" +
                                "username: ten dang nhap he thong\n\t" +
                                "password: mat khau dang nhap he thong\n\t" +
                                "database: ten co so du lieu\n");
            xmlW.WriteStartElement("config");

            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("servname");
            xmlW.WriteString(servname);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString("");
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString("");
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(database);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }

        public static void XMLWriter(String filename, String servname, String username, String password, String database, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(filename, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                "Thong so co ban:\n\t" +
                                "costatus = true : quyen Windows\n\t" +
                                "costatus = false: quyen SQL Server\n\t" +
                                "servname: ten server\n\t" +
                                "username: ten dang nhap he thong\n\t" +
                                "password: mat khau dang nhap he thong\n\t" +
                                "database: ten co so du lieu\n");
            xmlW.WriteStartElement("config");

            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("servname");
            xmlW.WriteString(servname);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString(username);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString(password);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(database);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }
    }
}