using FinalProject_ManagingEmployees.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_ManagingEmployees.BL
{
    public class City
    {
        private int m_id;
        private string m_name;

        public int Id { get => m_id; set => m_id = value; }
        public string Name { get => m_name; set => m_name = value; }

        public City() { }

        public City(DataRow dataRow)
        {
            //מייצרת יישוב מתוך שורת יישוב

            this.Id = (int)dataRow["ID"];
            m_name = dataRow["Name"].ToString();
        }

        public override string ToString()
        { return $"{m_name}"; }

        public bool Insert()
        {
            return CityDal.Insert(m_name);
        }

        public bool Update()
        {
            return CityDal.Update(Id, m_name);
        }

        public bool Delete()
        {
            return CityDal.Delete(m_id);
        }
    }
}
