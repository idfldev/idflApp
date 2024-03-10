import { useEffect, useState } from "react";
import { ProjectMainInformationDetail } from "./project-main-information";
import { useParams } from "react-router-dom";
import axios from "axios";
export const ProjectDetailApp = () => {
  const { id } = useParams();
  const [projectDetail, setProjectDetail] = useState();
  useEffect(() => {
    const getProjectDetail = async () => {
      try {
        const response = await axios.get(`api/management/project/${id}`);
        setProjectDetail(response.data);
      } catch (error) {}
    };
    getProjectDetail();
  }, [id]);
  return (
    <>
      <ProjectMainInformationDetail projectDetail={projectDetail} />
    </>
  );
};
