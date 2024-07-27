namespace examen_U2.Dtos.Clientes
{
    public class ClienteDto
    {
        public Guid identityNumber { get; set; }
        public string name { get; set; }
        public  string loanAmount { get; set; }
        public  string commissionRate { get; set; }
        public  string interestRate { get; set; }
        public  string term { get; set; }
        public  DateTime disbursementDate { get; set; }
        public  DateTime firstPaymentDate { get; set; }
    }
}
