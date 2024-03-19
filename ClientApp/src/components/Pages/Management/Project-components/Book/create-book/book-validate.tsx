// validationRules.ts

export type FieldValue = string | number | any[];

export interface FieldInterfaces {
  title: string;
  factory: string;
  dataUser: any[];
  startDate: any;
  endDate: any;
}

export const requiredFieldsValidationRules = (fields: FieldInterfaces) => [
  {
    fieldName: "Booking Title",
    value: fields.title,
    errorMessage: "Title is required",
    validator: (value: string) => typeof value === "string" && !!value.trim(),
  },
  {
    fieldName: "Factory",
    value: fields.factory,
    errorMessage: "Factory is required",
    validator: (value: string) => typeof value === "string" && !!value.trim(),
  },
  {
    fieldName: "Auditor",
    value: fields.dataUser,
    errorMessage: "Auditor is required",
    validator: (value: any[]) => value.length > 0,
  },
  {
    fieldName: "Start Date",
    value: fields.startDate,
    errorMessage: "Start Date is required",
    validator: (value: string) => value === null,
  },
  {
    fieldName: "End Date",
    value: fields.endDate,
    errorMessage: "End Date is required",
    validator: (value: string) => value === null,
  },
];
