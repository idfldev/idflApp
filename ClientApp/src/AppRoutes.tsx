import AppointmentScheduler from "components/Pages/Management/Project-components/Book/book-schedule";
import { ProjectApp } from "components/Pages/Management/Project-components/Project";
import BookCreateForm from "components/Pages/Management/Project-components/Project/project-create/book-create-form";
import { ProjectDetailApp } from "components/Pages/Management/Project-components/Project/project-detail";

const AppRoutes = [
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
  {
    path: "project/book-schedule",
    element: <AppointmentScheduler />,
  },
];

export default AppRoutes;
