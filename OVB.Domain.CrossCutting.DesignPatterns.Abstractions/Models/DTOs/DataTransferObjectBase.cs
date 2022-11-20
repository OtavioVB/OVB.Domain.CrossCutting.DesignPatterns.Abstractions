namespace OVB.Domain.CrossCutting.DesignPatterns.Abstractions.Models.DTOs;

public abstract class DataTransferObjectBase
{
    public Guid Identifier { get; set; }
    public DateTime RegisteredOn { get; set; }
    public DateTime LastModificationOn { get; set; }
    public Guid RegisteredBy { get; set; }
    public Guid LastModificationBy { get; set; }

    protected DataTransferObjectBase(Guid identifier, DateTime registeredOn, DateTime lastModificationOn, Guid registeredBy, Guid lastModificationBy)
    {
        Identifier = identifier;
        RegisteredOn = registeredOn;
        LastModificationOn = lastModificationOn;
        RegisteredBy = registeredBy;
        LastModificationBy = lastModificationBy;
    }
}
