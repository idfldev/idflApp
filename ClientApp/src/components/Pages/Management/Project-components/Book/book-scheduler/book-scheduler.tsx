import "devextreme/dist/css/dx.light.css";
import Scheduler, {
  Resource,
  SchedulerTypes,
} from "devextreme-react/scheduler";

import { data, resourcesData } from "./dataSource";

const currentDate = new Date();
const views: SchedulerTypes.ViewType[] = [
  "timelineDay",
  "timelineWeek",
  "timelineWorkWeek",
  "timelineMonth",
];
const groups = ["auditors"];

const BookScheduler = () => (
  <>
    <Scheduler
      dataSource={data}
      views={views}
      defaultCurrentView="timelineMonth"
      defaultCurrentDate={currentDate}
      height={380}
      groups={groups}
      cellDuration={60}
      firstDayOfWeek={0}
      startDayHour={8}
      endDayHour={20}
    >
      <Resource
        fieldExpr="auditors"
        allowMultiple={true}
        dataSource={resourcesData}
        label="Audit name"
      />
    </Scheduler>
  </>
);

export default BookScheduler;
