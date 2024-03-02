import React from "react";
import { Container } from "reactstrap";
import { NavbarManagement } from "./Navbar/navbar-management";
interface LayoutManagementProps {
    children?: React.ReactNode;
}
export const LayoutManagement: React.FC<LayoutManagementProps> = (props) =>{
    return (
        <div>
            <NavbarManagement/>
            <Container tag="main">
            {props.children !== undefined && props.children}
            </Container>
        </div>
    )
}