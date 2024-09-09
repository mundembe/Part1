public class Claim
{
    public int ClaimID { get; set; }
    public DateTime ClaimDate { get; set; }
    public float HoursWorked { get; set; }
    public float HourlyRate { get; set; }
    public float TotalAmount { get; set; }
    public string Status { get; set; }
}