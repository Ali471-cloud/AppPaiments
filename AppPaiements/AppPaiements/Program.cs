public abstract class Paiement
{
    public string IdTransaction { get; set; }
    public DateTime DateTransaction { get; set; }
    public decimal Montant { get; set; }

    public abstract void AfficherDetails();
}
