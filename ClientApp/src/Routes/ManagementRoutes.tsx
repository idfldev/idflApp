import { ProjectApp } from "components/Pages/Management/Project-components/Project";
import BookCreateForm from "components/Pages/Management/Project-components/Book/create-book/book-create-form";
import { ProjectDetailApp } from "components/Pages/Management/Project-components/Project/project-detail";

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
    }
  ];