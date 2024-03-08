import { LoginApp } from "components/Pages/Management/Login/login";
import { ProjectApp } from "components/Pages/Management/Project-components/Project";
import { ProjectDetail } from "components/Pages/Management/Project-components/Project/project-detail";

const AppRoutes = [
  {
    index: true,
    element: <LoginApp />,
  },
  {
    path: "/management-dashboard",
    element: <ProjectApp />,
  },
  {
    path: "/management-dashboard/project-detail",
    element: <ProjectDetail />,
  },
];

export default AppRoutes;
