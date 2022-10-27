using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CardManager : ICardService
    {
        ICardDal _cardDal;

        public CardManager(ICardDal cardDal)
        {
            _cardDal = cardDal;
        }

        public IResult Add(Card card)
        {
            _cardDal.Add(card);
            return new SuccessResult();
        }

        public IResult Delete(Card card)
        {
            _cardDal.Delete(card);
            return new SuccessResult();
        }

        public IDataResult<List<Card>> GetAll()
        {
            return new SuccessDataResult<List<Card>>(_cardDal.GetAll());
        }

        public IDataResult<Card> GetByCardId(int cardId)
        {
            return new SuccessDataResult<Card>(_cardDal.Get(c => c.CardId == cardId));
        }

        public IDataResult<List<Card>> GetCardsByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Card>>(_cardDal.GetAll(c => c.CustomerId == customerId));
        }

        public IResult Update(Card card)
        {
            _cardDal.Update(card);
            return new SuccessResult();
        }
    }
}
