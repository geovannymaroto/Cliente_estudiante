﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_Estudiante
{
    public partial class Form1 : Form
    {
        TcpClient clienteSocket = new TcpClient();
        public Form1(string nombre)
        {
            InitializeComponent();
            clienteSocket.Connect("127.0.0.1", 8080);
            lblnombre.Text = nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string men = "";
                //if (btnverdadero.Checked)
                //{
                //    men = txtpregunta.Text + ",1";
                //}
                //else if (btnfalso.Checked)
                //{
                //    men = txtpregunta.Text + ",0";
                //}

                //NetworkStream serverStream = clienteSocket.GetStream();
                //byte[] mensajeCliente = System.Text.Encoding.ASCII.GetBytes(men + "$");
                //serverStream.Write(mensajeCliente, 0, mensajeCliente.Length);
                //serverStream.Flush();

                //byte[] mensajeServidor = new byte[10025];
                //serverStream.Read(mensajeServidor, 0, 10024);
                //string me = System.Text.Encoding.ASCII.GetString(mensajeServidor);
                //string[] Rival = me.Split(new Char[] { ';' });

               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            try
            {
                
                NetworkStream serverStream = clienteSocket.GetStream();
                byte[] mensajeCliente = System.Text.Encoding.ASCII.GetBytes("estudiante,solicitar pregunta" + "$");
                serverStream.Write(mensajeCliente, 0, mensajeCliente.Length);
                serverStream.Flush();

                byte[] mensajeServidor = new byte[10025];
                serverStream.Read(mensajeServidor, 0, 10024);
                string me = System.Text.Encoding.ASCII.GetString(mensajeServidor);
                me = me.Substring(0, me.IndexOf("$"));

                txtpregunta.Text = me;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

}
