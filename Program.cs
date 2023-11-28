public class Liasse
{
    private static Liasse _instance;
    private List<Document> _documents;
 
    private Liasse()
    {
        _documents = new List<Document>();
    }
    // récupérer l'instance et la créer si pas existante
    public static Liasse GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Liasse();
        }
        return _instance;
    }
    public List<Document> GetDocuments()
    {
        return _documents;
    }

    public void SetDocuments(List<Document> documents)
    {
        _documents = documents;
    }
}

public abstract class Document
{
    public abstract void Duplique();
    public abstract void Imprime();
    public abstract void Affiche();
    public abstract void Remplit(string informations);
}

public class BonDeCommande : Document
{
    public override void Duplique();
    public override void Imprime();
    public override void Affiche()
    {
        throw new System.NotImplementedException();
    }
    public override void Remplit(string informations)
    {
        throw new System.NotImplementedException();
    }
}

public class DemandeImmatriculation : Document
{
    public override void Duplique();
    public override void Imprime();
    public override void Affiche()
    {
        throw new System.NotImplementedException();
    }
    public override void Remplit(string informations)
    {
        throw new System.NotImplementedException();
    }
}

public class CertificatCession : Document
{
    public override void Duplique();
    public override void Imprime();
    public override void Affiche()
    {
        throw new System.NotImplementedException();
    }
    public override void Remplit(string informations)
    {
        throw new System.NotImplementedException();
    }
}