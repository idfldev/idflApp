import React from "react";
import { Container } from "reactstrap";
import { NavbarManagement } from "./Navbar/navbar-management";
interface LayoutManagementProps {
  children?: React.ReactNode;
}
export const LayoutManagement: React.FC<LayoutManagementProps> = (props) => {
  return (
    <div className="flex">
      <NavbarManagement />
      <Container className="border">
        {props.children !== undefined && props.children}
      </Container>
    </div>
  );
};
