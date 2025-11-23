using FinalProject_ManagingEmployees.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.BL
{
    public class Street
    {
        private int m_id;
        private string m_name;

        public int Id { get => m_id; set => m_id = value; }
        public string Name { get => m_name; set => m_name = value; }

        public Street() { }

        public Street(DataRow dataRow)
        {
            //מייצרת רחוב מתוך שורת רחוב

            this.Id = (int)dataRow["ID"];
            m_name = dataRow["Name"].ToString();
        }

        public override string ToString()
        { return $"{m_name}"; }

        public bool Insert()
        {
            return StreetDal.Insert(m_name);
        }

        public bool Update()
        {
            return StreetDal.Update(Id, m_name);
        }

        public bool Delete()
        {
            return StreetDal.Delete(m_id);
        }
    }
}
