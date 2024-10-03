using BarberCompany.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberCompany.UserControls
{
    public partial class UserControlServiceHair : UserControl
    {
        public UserControlServiceHair(ServiceBarber service)
        {
            InitializeComponent();
            this.Margin = new Padding(20);

            if (service != null)
            {
                lbNameService.Text = service.NameService;
                lbDescriptionService.Text = service.DescriptionService;
                lbCostService.Text = service.ServiceCost.ToString();
            }
            else
            {
                lbNameService.Text = "Servicio no disponible";
            }
        }
    }
}
