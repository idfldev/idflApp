import Home from "components/Home";
import { FetchData } from "./components/FetchData";
import { LoginApp } from "components/Pages/Management/Login/login";
import { ManagementApp } from "components/Pages/Management";

const AppRoutes = [
  {
    index: true,
    element: <FetchData />,
  },
  {
    path: "/management",
    element: <LoginApp />,
  },
  {
    path: "/management-dashboard",
    element: <ManagementApp />,
  },
];

export default AppRoutes;
