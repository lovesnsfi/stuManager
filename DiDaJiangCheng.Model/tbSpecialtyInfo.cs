using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace DiDaJiangCheng.Model{
	 	//tbSpecialtyInfo
		public class tbSpecialtyInfo
	{
   		     
      	/// <summary>
		/// SpecialtyId
        /// </summary>		
		private int _specialtyid;
        public int SpecialtyId
        {
            get{ return _specialtyid; }
            set{ _specialtyid = value; }
        }        
		/// <summary>
		/// SpecialtyName
        /// </summary>		
		private string _specialtyname;
        public string SpecialtyName
        {
            get{ return _specialtyname; }
            set{ _specialtyname = value; }
        }        
		/// <summary>
		/// SpecialtyDescription
        /// </summary>		
		private string _specialtydescription;
        public string SpecialtyDescription
        {
            get{ return _specialtydescription; }
            set{ _specialtydescription = value; }
        }        
		   
	}
}

