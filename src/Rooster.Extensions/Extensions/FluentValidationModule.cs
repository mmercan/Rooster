using System;
using Microsoft.Framework.ConfigurationModel;
using FluentValidation.Attributes;
using FluentValidation.Results;
using System.Collections.Generic;

using Rooster.Extensions.Interfaces;
using Rooster.Extensions.ExtensionConfig;
using Rooster.Model.Interfaces;

namespace Rooster.Extensions
{
    public class FluentValidationModule : IExtension
    {
        public void Initialize(RepositoryExtensionFactory.ExtensionEvents events, IConfiguration config)
        {
            events.AddtoValidateEntity(e =>
            {
                if (e.Entity is IValidate)
                {
                    IValidate model = e.Entity as IValidate;
                    e.Result = model.ValidateModel(model);
                }
                else
                {
                    AttributedValidatorFactory validatorFactory = new AttributedValidatorFactory();

                    var validator = validatorFactory.GetValidator(e.Entity.GetType());
                    ValidationResult validationResults = validator.Validate(e.Entity);

                    IList<IValidationError> errors = new List<IValidationError>();


                    foreach (var error in validationResults.Errors)
                    {
                        errors.Add(new GenericValidationError { PropertyName = error.PropertyName, ValidationError = error.ErrorMessage });
                    }
                    IValidationResult ErrorResult = new GenericValidationResult { IsValid = validationResults.IsValid, Errors = errors };
                    e.Result = ErrorResult;
                }
            });
        }
    }
}