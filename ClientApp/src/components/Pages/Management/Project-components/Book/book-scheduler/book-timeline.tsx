import { Scheduler, SchedulerProjectData } from "@bitnoi.se/react-scheduler";
import { useCallback, useEffect, useState } from "react";
import "./book-timeline.css"
import ServiceBook from "services/service-book";
interface ParsedDatesRange {
  startDate: Date;
  endDate: Date;
}
const BookTimeSchedule: React.FC = () => {
  var resources = ServiceBook()
  console.log("fetching data: ", resources)
  const [range, setRange] = useState<ParsedDatesRange>({
    startDate: new Date(),
    endDate: new Date(),
  });
  useEffect(() => { }, []);
  const handleRangeChange = useCallback((range: ParsedDatesRange) => {
    setRange(range);
  }, []);
  const handleTitleClick = (data: SchedulerProjectData) => {
    alert(`item ${data.title} + description: ${data.description}`);
  };
  return (
    <>
      <div>
        <Scheduler
          data={resources}
          isLoading={false}
          onRangeChange={handleRangeChange}
          onTileClick={handleTitleClick}
          onItemClick={(data) =>
            alert(
              "Item was click" +
              "" +
              data.label.title +
              "" +
              data.label.subtitle
            )
          }
          config={{
            zoom: 1,
            maxRecordsPerPage: 10,
            filterButtonState: -1,
            includeTakenHoursOnWeekendsInDayView: true,
          }}
        />
      </div>
    </>
  );
};
export default BookTimeSchedule;
