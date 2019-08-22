using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BussinessObject;
using Bussinesslogic;


namespace _3_tire_practice
{
    public partial class UserRegistraction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            UserBO userBO = new UserBO();
            userBO.Mobilenumber = txtmobile.Text;
            userBO.EmailID = txtEmailid.Text;
            userBO.Name = txtname.Text;
            userBO.address = txtAddress.Text;



            UserBL userBL = new UserBL();
            if (userBL.SaveUserregisrationBL(userBO) == 1)
            {

            }
            else
            {

            }

        }
    }
}