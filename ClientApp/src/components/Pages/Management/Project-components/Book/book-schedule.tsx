import React, { useState } from "react";
import "./book-schedule.css"
import Datepicker from "react-tailwindcss-datepicker";

interface Appointment {
  id: number;
  startDate: string;
  endDate: string;
  staff: string;
}

const appointments: Appointment[] = [
  {
    id: 1,
    startDate: "2024-03-10T08:00:00",
    endDate: "2024-03-10T09:00:00",
    staff: "John",
  },
  {
    id: 2,
    startDate: "2024-03-10T10:00:00",
    endDate: "2024-03-10T11:00:00",
    staff: "Jane",
  },
  // Add more appointments as needed
];

const BookScheduleApp: React.FC = () => {
  const [selectedDate, setSelectedDate] = useState({
    startDate: null,
    endDate: null, // Convert the result to a Date object
  });

  const groupAppointmentsByStaff = (appointments: Appointment[]) => {
    const groupedAppointments: Record<string, Appointment[]> = {};
    appointments.forEach((appointment) => {
      if (!groupedAppointments[appointment.staff]) {
        groupedAppointments[appointment.staff] = [];
      }
      groupedAppointments[appointment.staff].push(appointment);
    });
    return groupedAppointments;
  };

  const groupedAppointments = groupAppointmentsByStaff(appointments);

  const daysOfWeek = [
    "Sunday",
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
  ];

  const handleDateChange = (date: any | null) => {
    if (date) {
      setSelectedDate(date);
    }
  };

  return (
    <div>
      <div className="calendar-container">
        <Datepicker
          useRange={false}
          asSingle={true}
          value={selectedDate}
          onChange={handleDateChange}
        />
      </div>
      <div className="schedule-container">
        <div className="staff-column">
          {Object.keys(groupedAppointments).map((staff) => (
            <div className="staff" key={staff}>
              {staff}
            </div>
          ))}
        </div>
        <div className="days-row">
          {daysOfWeek.map((day) => (
            <div className="day" key={day}>
              {day}
            </div>
          ))}
        </div>
        <div className="appointments-grid">
          {Object.values(groupedAppointments).map(
            (staffAppointments, staffIndex) => (
              <div className="staff-appointments" key={staffIndex}>
                {daysOfWeek.map((day, dayIndex) => {
                  const appointmentsForDay = staffAppointments.filter(
                    (appointment) => {
                      const startDate = new Date(appointment.startDate);
                      return startDate.getDay() === dayIndex;
                    }
                  );

                  return (
                    <div className="day-appointments" key={dayIndex}>
                      {appointmentsForDay.map((appointment) => (
                        <div className="appointment" key={appointment.id}>
                          {`${appointment.startDate} - ${appointment.endDate}`}
                        </div>
                      ))}
                    </div>
                  );
                })}
              </div>
            )
          )}
        </div>
      </div>
    </div>
  );
};

export default BookScheduleApp;
