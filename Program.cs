namespace Gestor_de_servicios_Tecnicos
{
    public enum UserGrants
    {
        //TODO: Reformular un sistema de permisos mas acorde
        ALLOW_CLIENT_ADD            = 1 << 0,
        ALLOW_CLIENT_FULL_VIEW      = 1 << 1,
        ALLOW_CLIENT_CHANGE         = 1 << 2,
        ALLOW_EQUIPMENT_FULL_VIEW   = 1 << 3,
        ALLOW_EQUIPMENT_ADD         = 1 << 4,
        ALLOW_EQUIPMENT_CHANGE      = 1 << 5,
        ALLOW_BUDGET_ADD            = 1 << 6,
        ALLOW_BUDGET_CHANGE         = 1 << 7,
        ALLOW_BUDGET_FULLVIEW       = 1 << 8,
        ALLOW_JOB_ORDER_ADD         = 1 << 9,
        ALLOW_JOB_ORDER_CHANGE      = 1 << 10,
        ALLOW_JOB_ORDER_FULLVIEW    = 1 << 11,
        ALLOW_PREVENTIVE_ADD        = 1 << 12,
        ALLOW_PREVENTIVE_CHANGE     = 1 << 13,
        ALLOW_PREVENTIVE_FULLVIEW   = 1 << 14,
        RESERVED_1                  = 1 << 15,
        RESERVED_2                  = 1 << 16,

        ROL_NONE                    = 0,
        ROL_TECHNIC = ALLOW_EQUIPMENT_FULL_VIEW + ALLOW_EQUIPMENT_ADD,
        ROL_ADMIN                   = 0xFFFF,
        //R_SELLER = A_SALESVIEW | A_SALESADD | A_CLIENTCHANGE | A_STOCKVIEW | A_PURCHASESVIEW | A_REPORTSVIEW,
        //R_REPOSITOR = A_PRODUCTADD | A_PURCHASECHANGE | A_SUPPLIERSCHANGE,
        //R_ADVANCED = R_SELLER | R_REPOSITOR,
        //R_AUDITOR = A_STOCKVIEW | A_CLIENTVIEW | A_PURCHASESVIEW | A_SUPPLIERSVIEW | A_REPORTSVIEW | A_SALESVIEW,
        //R_GERENT = 1 << 14 | R_REPOSITOR | R_SELLER | R_AUDITOR | A_SALESCHANGE
    }
    public class User
    {
        public string Name { get; set; }
        public UserGrants Grants { get; set; }
        public User(String Name = "Desconocido", UserGrants Grants = UserGrants.ROL_NONE)
        {
            this.Name = Name;
            this.Grants = Grants;
        }
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }
    }
}