import { ProjectApp } from "components/Pages/Management/Project-components/Project";
import BookCreateForm from "components/Pages/Management/Project-components/Book/create-book/book-create-form";
import { ProjectDetailApp } from "components/Pages/Management/Project-components/Project/project-detail";
import BookTimeSchedule from "components/Pages/Management/Project-components/Book/create-book/book-scheduler/book-timeline";
import { Scheduler } from "@bitnoi.se/react-scheduler";
import BookScheduleTimeLine from "components/Pages/Management/Project-components/Book/create-book/book-scheduler/time-line";
export const ManagementRoutes = [
    {
      path: "/",
      element: <ProjectApp />,
    },
    {
      path: "project/book-create/:id",
      element: <BookCreateForm />,
    },
    {
      path: "project/project-detail/:id",
      element: <ProjectDetailApp />,
    },
    // {
    //   path: "project/book",
    //   element: <BookScheduler />,
    // },
    {
      path: "project/book",
      element: <BookScheduleTimeLine/>,
    }
  ];