using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;

namespace LNStone.Models
{
    public class StoneService
    {
        readonly LNStoneDbEntities ObjContext;

        public StoneService()
        {
            ObjContext = new LNStoneDbEntities();
        }

        #region Instruction: GetAll
        public List<StoneDTO> GetAll()
        {
            List<StoneDTO> ObjStoneList = new List<StoneDTO>();
            try
            {
                var ObjQuery = from obj in ObjContext.Stone
                               select obj;
                foreach (var stone in ObjQuery)
                {
                    ObjStoneList.Add(new StoneDTO
                    {
                        Id = stone.Id,
                        StoneName = stone.Stone_Name,
                        DiameterOfStone = stone.Diameter_of_Stone,
                        CordPrice = stone.Cord_Price,
                        AmountOfStone = stone.Amount_of_Stone,
                        PricePerStone = stone.Price_per_Stone,
                        Store = stone.Store,
                        Faceting = stone.Faceting
                    });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ObjStoneList;
        }
        #endregion

        #region Instruction: Add
        public bool Add(StoneDTO objNewStone)
        {
            bool IsAdded = false;

            try
            {
                var ObjStone = new Stone
                {
                    Id = objNewStone.Id,
                    Stone_Name = objNewStone.StoneName,
                    Diameter_of_Stone = objNewStone.DiameterOfStone,
                    Cord_Price = objNewStone.CordPrice,
                    Amount_of_Stone = objNewStone.AmountOfStone,
                    Price_per_Stone = objNewStone.PricePerStone,
                    Store = objNewStone.Store,
                    Faceting = objNewStone.Faceting
                };
                ObjContext.Stone.Add(ObjStone);
                var NoOfRowsAffected = ObjContext.SaveChanges();
                IsAdded = NoOfRowsAffected > 0;
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
            }
            return IsAdded;
        }
        #endregion

        #region Instruction: Update
        public bool Update(StoneDTO objStoneToUpdate)
        {
            bool IsUpdated = false;

            try
            {
                var ObjStone = ObjContext.Stone.Find(objStoneToUpdate.Id);

                if (ObjStone == null)
                {
                    throw new ArgumentException("Form cannot be null!");
                }

                ObjStone.Stone_Name = objStoneToUpdate.StoneName;
                ObjStone.Diameter_of_Stone = objStoneToUpdate.DiameterOfStone;
                ObjStone.Cord_Price = objStoneToUpdate.CordPrice;
                ObjStone.Amount_of_Stone = objStoneToUpdate.AmountOfStone;
                ObjStone.Price_per_Stone = objStoneToUpdate.PricePerStone;
                ObjStone.Store = objStoneToUpdate.Store;
                ObjStone.Faceting = objStoneToUpdate.Faceting;
                var NoOfRowsAffected = ObjContext.SaveChanges();
                IsUpdated = NoOfRowsAffected > 0;
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return IsUpdated;
        }
        #endregion

        #region Instruction: Delete
        public bool Delete(int? id)
        {
            bool IsDeleted = false;
            try
            {
                var ObjStoneToDeleted = ObjContext.Stone.Find(id);
                ObjContext.Stone.Remove(ObjStoneToDeleted);
                var NoOfRowsAffected = ObjContext.SaveChanges();
                IsDeleted = NoOfRowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return IsDeleted;
        }
        #endregion

        #region Instruction: View
        public StoneDTO View(int? Id)
        {
            StoneDTO ObjStone = null;

            try
            {
                var ObjStoneToFind = ObjContext.Stone.Find(Id);
                if (ObjStoneToFind != null)
                {
                    ObjStone = new StoneDTO()
                    {
                        Id = ObjStoneToFind.Id,
                        StoneName = ObjStoneToFind.Stone_Name,
                        DiameterOfStone = ObjStoneToFind.Diameter_of_Stone,
                        CordPrice = ObjStoneToFind.Cord_Price,
                        AmountOfStone = ObjStoneToFind.Amount_of_Stone,
                        PricePerStone = ObjStoneToFind.Price_per_Stone,
                        Store = ObjStoneToFind.Store,
                        Faceting = ObjStoneToFind.Faceting
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ObjStone;
        }
        #endregion
    }
}
