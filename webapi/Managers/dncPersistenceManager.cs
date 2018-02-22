using Breeze.Persistence.EFCore;
using model;

public class dncPersistenceManager : EFPersistenceManager<dncContext> {    
    public dncPersistenceManager(dncContext dbContext) : base(dbContext) { }
}
