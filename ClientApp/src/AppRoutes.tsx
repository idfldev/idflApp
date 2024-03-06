import { LoginApp } from "components/Pages/Management/Login/login";
import { ProjectApp } from "components/Pages/Management/Project-components";

const AppRoutes = [
  {
    index:true,
    element: <LoginApp />,
  },
  {
    path: "/management-dashboard",
    element: <ProjectApp />,
  },
];

export default AppRoutes;
