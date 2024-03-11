import { SchedulerTypes } from "devextreme-react/scheduler";

type Appointment = SchedulerTypes.Appointment & {
  auditors: number;
};

type Resource = {
  text: string;
  id: number;
  color: string;
};

export const data: Appointment[] = [
  {
    text: "Nhà máy SCCC",
    description: "them tong tin",
    startDate: new Date("2024-03-01T16:00:00.000Z"),
    endDate: new Date("2024-03-03T16:30:00.000Z"),
    auditors: 4,
  },
  {
    text: "Nhà máy SCCC",
    description: "them tong tin",
    startDate: new Date("2024-03-02T16:00:00.000Z"),
    endDate: new Date("2024-03-03T16:30:00.000Z"),
    auditors: 3,
  },
  {
    text: "Nhà máy SCCC",
    description: "them tong tin",
    startDate: new Date("2024-03-02T16:00:00.000Z"),
    endDate: new Date("2024-03-03T16:30:00.000Z"),
    auditors: 3,
  },
  {
    text: "Nhà máy SCCC",
    description:"them tong tin",
    startDate: new Date("2024-03-02T16:00:00.000Z"),
    endDate: new Date("2024-03-03T16:30:00.000Z"),
    auditors: 3,
  },
];

export const resourcesData: Resource[] = [
  {
    text: "Tommy To",
    id: 1,
    color: "#cb6bb2",
  },
  {
    text: "David Pham",
    id: 2,
    color: "#56ca85",
  },
  {
    text: "Sandra Tom",
    id: 3,
    color: "#1e90ff",
  },
  {
    text: "Sandra Johnson",
    id: 4,
    color: "#ff9747",
  },
];
