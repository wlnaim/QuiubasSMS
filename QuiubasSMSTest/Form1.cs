using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuiubasSMSTest
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnEnviar_Click(object sender, EventArgs e)
    {
      String mensajeEncoded = System.Web.HttpUtility.HtmlEncode(txtMensaje.Text);
      String quiubasWebRequest = String.Format("https://api.quiubas.com:9443/api?action=sendmessage&username=ernestodelacruzmoralesB80&password=DECAA7&recipient={0}&messagedata={1}&responseformat=xml",
        txtDestino.Text, mensajeEncoded);

      WebRequest request = WebRequest.Create(quiubasWebRequest);
      request.Method = "POST";
      ((HttpWebRequest) request).UserAgent = "Mozilla/5.0 (compatible, MSIE 11, Windows NT 6.3; Trident/7.0; rv:11.0) like Gecko";
      string postData = "";
      byte[] byteArray = Encoding.UTF8.GetBytes(postData);
      request.ContentType = "application/x-www-form-urlencoded";
      request.ContentLength = byteArray.Length;
      Stream dataStream = request.GetRequestStream();
      dataStream.Write(byteArray, 0, byteArray.Length);
      dataStream.Close();
      WebResponse response = request.GetResponse();
      txtResponse.Text += ((HttpWebResponse) response).StatusDescription + Environment.NewLine;
      dataStream = response.GetResponseStream();
      StreamReader reader = new StreamReader(dataStream);
      string responseFromServer = reader.ReadToEnd();
      txtResponse.Text += responseFromServer;
      reader.Close();
      dataStream.Close();
      response.Close();

      MessageBox.Show("SMS enviado!!!");
    }
  }
}
