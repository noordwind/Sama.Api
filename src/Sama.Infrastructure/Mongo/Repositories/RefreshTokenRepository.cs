using System;
using System.Threading.Tasks;
using Sama.Core.Domain.Identity;
using Sama.Core.Domain.Identity.Repositories;

namespace Sama.Infrastructure.Mongo.Repositories
{
    public class RefreshTokenRepository : IRefreshTokenRepository
    {
        private readonly IMongoRepository<RefreshToken> _repository;

        public RefreshTokenRepository(IMongoRepository<RefreshToken> repository)
        {
            _repository = repository;
        }

        public async Task<RefreshToken> GetAsync(string token)
            => await _repository.GetAsync(x => x.Token == token);

        public async Task CreateAsync(RefreshToken token)
            => await _repository.CreateAsync(token);

        public async Task UpdateAsync(RefreshToken token)
            => await _repository.UpdateAsync(token);
    }
}