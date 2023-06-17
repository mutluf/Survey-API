﻿using AutoMapper;
using MaSurvey.Application.Repositories;
using MaSurvey.Domain.Entities;
using MediatR;

namespace MaSurvey.Application.Features.Commands.Options.CreateOption
{
    public class CreateSurveyHandler : IRequestHandler<CreateOptionRequest>
    {
        private readonly IMapper _mapper;
        private readonly IOptionRepository _optionRepository;
        public CreateSurveyHandler(IMapper mapper, IOptionRepository optionRepository)
        {
            _mapper = mapper;
            _optionRepository = optionRepository;
        }

        public async Task<Unit> Handle(CreateOptionRequest request, CancellationToken cancellationToken)
        {
            Option option = _mapper.Map<Option>(request);
            await _optionRepository.AddAysnc(option);
            await _optionRepository.SaveAysnc();

            return Unit.Value;
        }
    }
}
