namespace ClinicAPI.Models.DTO
{
    public class Dashboard_ReportResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        //public int NumberOfAppointment { get; set; }
        public List<MonthlyAppointmentsDto> MonthlyAppointments { set; get; }
    }
}

public class AggAppointmentDto
{
    public string Date { get; set; } = default!;
    public string Time { get; set; } = default!;
    public string State { get; set; } = default!;
}

public class MonthlyAppointmentsDto
{
    public string Month { get; set; } = default!;
    public List<AggAppointmentDto> Appointments { get; set; } = new();

    public int AppointmentCount { set; get; }
}
