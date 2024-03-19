import React from "react";
import Navbar from "./navbar/Navbar";
import Footer from "./footer/Footer";
interface LayoutProfileProps {
  children?: React.ReactNode;
}
export const LayoutProfiles: React.FC<LayoutProfileProps> = (props) => {
  return (
    <div>
      <Navbar />
      <div>{props.children !== undefined && props.children}</div>
      <Footer />
    </div>
  );
};
