import { ProjectApp } from "components/Pages/Management/Project-components/Project";
import BookCreateForm from "components/Pages/Management/Project-components/Project/book-create-form";
import { ProjectDetail } from "components/Pages/Management/Project-components/Project/project-detail";

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
    path: "project/project-detail",
    element: <ProjectDetail />,
  },
];

export default AppRoutes;
