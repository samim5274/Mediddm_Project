using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidProject
{
    class Manager
    {
        
        public object GetAllType()
        {
            var obj = new MEDIDDMEntities();
            var q = from TF in obj.TypeInfoes select TF;
            return q.ToList();
        }

        public object GetAllGender()
        {
            var obj = new MEDIDDMEntities();
            var q = from G in obj.GenderInfoes select G;
            return q.ToList();
        }

        public object GetAllDepartment()
        {
            var obj = new MEDIDDMEntities();
            var q = from D in obj.DepartmentInfoes select D;
            return q.ToList();
        }

        public List<SP_Day_And_Day_Diposit_And_Expenses_Report_Result> GetDayWiseDepositAndExpensesReport(DateTime sD, DateTime eD)
        {
            var context = new MEDIDDMEntities();
            var q = context.SP_Day_And_Day_Diposit_And_Expenses_Report(sD, eD);
            return q.ToList();
        }

        public List<SP_Show_Student_Info_Result> GetStudentInfo()
        {
            var context = new MEDIDDMEntities();
            var q = context.SP_Show_Student_Info();
            return q.ToList();
        }

        public List<SP_Day_And_Name_Report_Result> GetDayAndNameWiseReport(DateTime sD, DateTime eD, int uN)
        {
            var context = new MEDIDDMEntities();
            var q = context.SP_Day_And_Name_Report(sD,eD,uN);
            return q.ToList();
        }

        public List<SP_Day_And_Transection_Type_Report_Result> GetTransectionTypeReport(DateTime sD, DateTime eD, int tT)
        {
            var context = new MEDIDDMEntities();
            var q = context.SP_Day_And_Transection_Type_Report(sD,eD,tT);
            return q.ToList();
        }

        internal object GetAllStudent()
        {
            var obj = new MEDIDDMEntities();
            var q = from S in obj.StudentInfoes select S;
            return q.ToList();
        }

        public List<SP_Show_Transection_Data_Info_Result> GettAllTransection()
        {
            var context = new MEDIDDMEntities();
            var q = context.SP_Show_Transection_Data_Info();
            return q.ToList();
        }

        public List<SP_Day_And_Purpose_Report_Result> GetPurposeReport(DateTime sD, DateTime eD, int pN)
        {
            var context = new MEDIDDMEntities();
            var q = context.SP_Day_And_Purpose_Report(sD,eD,pN);
            return q.ToList();
        }

        internal object GetUserStudent()
        {
            var obj = new MEDIDDMEntities();
            var q = from U in obj.UserInfoes select U;
            return q.ToList();
        }

        public List<SP_Giver_And_Receiver_Report_Result> GetDayReceiverGiverReport(DateTime sD, DateTime eD, int gN, int rN)
        {
            var context = new MEDIDDMEntities();
            var q = context.SP_Giver_And_Receiver_Report(sD,eD,gN,rN);
            return q.ToList();
        }

        public List<SP_7_Day_Data_Analysis_Result> GetAllValue2(DateTime d2, int v2)
        {
            var context = new MEDIDDMEntities();
            var q = context.SP_7_Day_Data_Analysis(d2, v2);
            return q.ToList();
        }

        public List<SP_7_Day_Data_Analysis_Result> GetAllValue4(DateTime d4, int v4)
        {
            var context = new MEDIDDMEntities();
            var q = context.SP_7_Day_Data_Analysis(d4, v4);
            return q.ToList();
        }

        public List<SP_7_Day_Data_Analysis_Result> GetAllValue5(DateTime d5, int v5)
        {
            var context = new MEDIDDMEntities();
            var q = context.SP_7_Day_Data_Analysis(d5, v5);
            return q.ToList();
        }

        public List<SP_7_Day_Data_Analysis_Result> GetAllValue6(DateTime d6, int v6)
        {
            var context = new MEDIDDMEntities();
            var q = context.SP_7_Day_Data_Analysis(d6, v6);
            return q.ToList();
        }

        public List<SP_7_Day_Data_Analysis_Result>  GetAllValue7(DateTime d7, int v7)
        {
            var context = new MEDIDDMEntities();
            var q = context.SP_7_Day_Data_Analysis(d7, v7);
            return q.ToList();
        }

        public List<SP_7_Day_Data_Analysis_Result> GetAllValue3(DateTime d3, int v3)
        {
            var context = new MEDIDDMEntities();
            var q = context.SP_7_Day_Data_Analysis(d3, v3);
            return q.ToList();
        }

        public List<SP_7_Day_Data_Analysis_Result> GetAllValue(DateTime d1, int v1)
        {
            var context = new MEDIDDMEntities();
            var q = context.SP_7_Day_Data_Analysis(d1,v1);
            return q.ToList();
        }
        

        public List<SP_Day_And_Giver_Report_Result> GetGiverReport(DateTime sD, DateTime eD, int gN)
        {
            var context = new MEDIDDMEntities();
            var q = context.SP_Day_And_Giver_Report(sD, eD, gN);
            return q.ToList();
        }

        internal object GetPersonalTransection()
        {
            var context = new MEDIDDMEntities();
            var q = from P in context.PersonalDipositInfoes select P;
            return q.ToList();
        }

        public List<SP_Day_And_Receiver_Report_Result> GetReceiverReport(DateTime sD, DateTime eD, int rN)
        {
            var context = new MEDIDDMEntities();
            var q = context.SP_Day_And_Receiver_Report(sD, eD, rN);
            return q.ToList();
        }

        internal object GettAllPurpose()
        {
            var obj = new MEDIDDMEntities();
            var q = from P in obj.PurposeInfoes select P;
            return q.ToList();
        }

        public List<SP_GName_RName_Date_Purpose_Report_Result> GetTransectionReport(DateTime sD, DateTime eD, int gN, int pN, int rN)
        {
            var obj = new MEDIDDMEntities();
            var q = obj.SP_GName_RName_Date_Purpose_Report(sD,eD,gN,pN,rN);
            return q.ToList();   
        }
    }
}
