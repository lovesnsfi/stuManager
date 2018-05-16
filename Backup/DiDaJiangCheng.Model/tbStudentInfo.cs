using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace DiDaJiangCheng.Model{
	 	//tbStudentInfo
		public class tbStudentInfo
	{
   		     
      	/// <summary>
		/// StuId
        /// </summary>		
		private int _stuid;
        public int StuId
        {
            get{ return _stuid; }
            set{ _stuid = value; }
        }        
		/// <summary>
		/// StuNo
        /// </summary>		
		private string _stuno;
        public string StuNo
        {
            get{ return _stuno; }
            set{ _stuno = value; }
        }        
		/// <summary>
		/// StuName
        /// </summary>		
		private string _stuname;
        public string StuName
        {
            get{ return _stuname; }
            set{ _stuname = value; }
        }        
		/// <summary>
		/// StuSex
        /// </summary>		
		private string _stusex;
        public string StuSex
        {
            get{ return _stusex; }
            set{ _stusex = value; }
        }        
		/// <summary>
		/// StuNation
        /// </summary>		
		private string _stunation;
        public string StuNation
        {
            get{ return _stunation; }
            set{ _stunation = value; }
        }        
		/// <summary>
		/// StuFamilyAddress
        /// </summary>		
		private string _stufamilyaddress;
        public string StuFamilyAddress
        {
            get{ return _stufamilyaddress; }
            set{ _stufamilyaddress = value; }
        }        
		/// <summary>
		/// StuContact
        /// </summary>		
		private string _stucontact;
        public string StuContact
        {
            get{ return _stucontact; }
            set{ _stucontact = value; }
        }        
		/// <summary>
		/// Stupolitics
        /// </summary>		
		private string _stupolitics;
        public string Stupolitics
        {
            get{ return _stupolitics; }
            set{ _stupolitics = value; }
        }        
		/// <summary>
		/// StuPostCode
        /// </summary>		
		private string _stupostcode;
        public string StuPostCode
        {
            get{ return _stupostcode; }
            set{ _stupostcode = value; }
        }        
		/// <summary>
		/// ClassId
        /// </summary>		
		private int _classid;
        public int ClassId
        {
            get{ return _classid; }
            set{ _classid = value; }
        }        
		/// <summary>
		/// StuPhoto
        /// </summary>		
		private byte[] _stuphoto;
        public byte[] StuPhoto
        {
            get{ return _stuphoto; }
            set{ _stuphoto = value; }
        }        
		   
	}
}

