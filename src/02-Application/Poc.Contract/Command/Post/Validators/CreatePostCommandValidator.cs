﻿using FluentValidation;
using Poc.Contract.Command.Post.Request;

namespace Poc.Contract.Command.Post.Validators;

public class CreatePostCommandValidator : AbstractValidator<CreatePostCommand>
{
    public CreatePostCommandValidator()
    {
        RuleFor(command => command.Title)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(command => command.Content)
            .NotEmpty()
            .MaximumLength(100);

    }
}
