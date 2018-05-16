using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
namespace DiDaJiangCheng.Model
{
    //tbClassInfo
    public class tbClassInfo
    {

        /// <summary>
        /// 班级编号
        /// </summary>		
        private int _classid;
        public int ClassId
        {
            get { return _classid; }
            set { _classid = value; }
        }
        /// <summary>
        /// 班级名称
        /// </summary>		
        private string _classname;
        public string ClassName
        {
            get { return _classname; }
            set { _classname = value; }
        }
        /// <summary>
        /// 专业名称
        /// </summary>		
        private int _specialtyid;
        public int SpecialtyId
        {
            get { return _specialtyid; }
            set { _specialtyid = value; }
        }
        /// <summary>
        /// 教室编号
        /// </summary>		
        private string _classroomid;
        public string classroomId
        {
            get { return _classroomid; }
            set { _classroomid = value; }
        }
        /// <summary>
        /// 学制
        /// </summary>		
        private string _eductionalsystem;
        public string eductionalSystem
        {
            get { return _eductionalsystem; }
            set { _eductionalsystem = value; }
        }
        /// <summary>
        /// 入学时间
        /// </summary>		
        private DateTime _entertime;
        public DateTime enterTime
        {
            get { return _entertime; }
            set { _entertime = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>		
        private string _marks;
        public string Marks
        {
            get { return _marks; }
            set { _marks = value; }
        }

    }
}

