import { useState } from 'react';

type FieldValue = string | number | any[];

type ValidationRule<T> = {
  fieldName: string;
  value: T;
  errorMessage: string;
  validator: (value: T) => boolean;
};

const useRequiredFieldsValidation = <T extends FieldValue>(
  validationRules: ValidationRule<T>[]
) => {
  const [errors, setErrors] = useState<string[]>([]); // Explicitly typing errors as string[]

  const validateFields = () => {
    const newErrors: string[] = [];
    validationRules.forEach(rule => {
      if (!rule.validator(rule.value)) {
        newErrors.push(rule.errorMessage);
      }
    });
    setErrors(newErrors);
    return newErrors.length === 0;
  };

  return { errors, validateFields };
};

export default useRequiredFieldsValidation;
