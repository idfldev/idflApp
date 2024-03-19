import { Fragment, useEffect, useState } from "react";
import axios from "axios";
import { Menu, Transition } from "@headlessui/react";
import { EllipsisHorizontalIcon } from "@heroicons/react/24/solid";
import { NavItem, NavLink } from "reactstrap";
import { Link, useBeforeUnload } from "react-router-dom";
import "./index.css";
import { FetchToken } from "hooks/fetch-token";
interface PaginationInterface {
  pageNumber: number,
  pageSize: number,
  firstPage: number,
  lastPage: number,
  totalPages: number,
  TotalRecords: number,
  nextPage: number,
  previousPage: number
};
export const ProjectApp: React.FC = () => {
  const [loading, setLoading] = useState<boolean>(true);
  const [project, setProject] = useState([]);
  const [pagination, setPagination] = useState<PaginationInterface | null>(null);

  const getProjectData = async () => {
    var data = {
      PageSize: 10,
      pageNumber: 1
    }
    try {
      const response = await axios.get("api/management/project", {
        params: data, // Use 'params' to pass data in GET requests
        headers: {
          Authorization: FetchToken
        }
      });
      console.log(response.data.data);
      setProject(response.data.data);
      setLoading(false);
    } catch (error) {
      setLoading(false);
    }
  };
  useEffect(() => {
    const successMessage = localStorage.getItem('successMessage');
    if (successMessage) {
      // Display the success message
      alert(successMessage);
      // Clear the success message from local storage
      localStorage.removeItem('successMessage');
    }
    getProjectData();
  }, []);
  function classNames(...classes: any) {
    return classes.filter(Boolean).join(" ");
  }
  return (
    <>
      <h1 className="uppercase pb-8 pt-20 px-4">Projects Information</h1>
      {loading && <span className="loader"></span>}
      <div className="relative border overflow-x-auto w-full pb-14">
        <table className="w-full text-sm text-left rtl:text-right text-gray-500 dark:text-gray-60">
          <thead className="text-xs text-gray-700 uppercase bg-gray-50  dark:text-gray-400">
            <tr className="w-full ">
              <th scope="col" className="px-6 h-24 text-center">
                No
              </th>
              <th scope="col" className="pe-28 h-24">
                <div className="w-28 pe-3 ">Company Name</div>
              </th>
              <th scope="col" className="pe-28 h-24">
                <div className="w-28 pe-3 ">Factories</div>
              </th>
              <th scope="col" className="h-24">
                <div className="w-60">Standard</div>
              </th>
              <th scope="col" className="h-24">
                <div className="w-28">
                  <h1>IDFL Code</h1>
                </div>
              </th>
              <th scope="col" className="h-24">
                <div className="w-28 pe-3 ">Issued Certificate date</div>
              </th>
              <th scope="col" className="pe-12 py-3">
                Expired Certificated
              </th>
              <th scope="col" className="pe-20 py-3">
                status
              </th>
              <th scope="col" className="pe-10 py-3">
                Actions
              </th>
            </tr>
          </thead>
          <tbody>
            {project.map((items: any, index: any) => (
              <tr
                key={index}
                className="odd:bg-white odd:dark:bg-gray-900 even:bg-gray-50 even:dark:bg-gray-800 border-b dark:border-gray-700"
              >
                <td className="px-10 py-3 text-center">{index}</td>
                <td className="py-4 font-medium text-gray-900 whitespace-nowrap dark:text-white">
                  {items.companyName}
                </td>
                <td>
                  {items.getFactoryResult.map((factory: any, idx: any) => (
                    <p className="text-cyan-600" key={idx}>{factory.unitName}</p>
                  ))}
                </td>
                <td className="py-3">{items.standard}</td>
                <td className="py-3">{items.refCode}</td>
                <td className="py-3">{items.issueCertificatedDate}</td>
                <td className="py-3">{items.certificationExpirationDate}</td>
                <td
                  className={`py-3 ${items.status === "Pending"
                    ? "text-red-500 font-bold"
                    : "" || items.status === "Verified"
                      ? "text-green-500 font-bold"
                      : ""
                    }`}
                >
                  {items.status}
                </td>


                <td>
                  <Menu as="div" className="relative inline-block text-left">
                    <div>
                      <Menu.Button className="inline-flex w-full justify-center gap-x-1.5 rounded-mdpx-3 py-2 text-sm font-semibold text-gray-900">
                        <EllipsisHorizontalIcon className="h-6 w-6 text-blue-500" />
                      </Menu.Button>
                    </div>

                    <Transition
                      as={Fragment}
                      enter="transition ease-out duration-100"
                      enterFrom="transform opacity-0 scale-95"
                      enterTo="transform opacity-100 scale-100"
                      leave="transition ease-in duration-75"
                      leaveFrom="transform opacity-100 scale-100"
                      leaveTo="transform opacity-0 scale-95"
                    >
                      <Menu.Items className="absolute right-0 z-10 mt-2 w-32 origin-top-right rounded-md bg-white shadow-lg ring-1 ring-black ring-opacity-5 focus:outline-none">
                        <ul className="py-1 navbar-nav ">
                          {items.status === "Certificated" ? (
                            <></>
                          ) : (
                            <Menu.Item>
                              {({ active }) => (
                                <NavItem>
                                  <NavLink
                                    className={classNames(
                                      active
                                        ? "bg-gray-100 text-gray-900"
                                        : "text-gray-700",
                                      "block px-4 py-2 text-sm"
                                    )}
                                    tag={Link}
                                    to={`project/book-create/${items.id}`}
                                  >
                                    Book
                                  </NavLink>
                                </NavItem>
                              )}
                            </Menu.Item>
                          )}

                          <Menu.Item>
                            {({ active }) => (
                              <NavItem>
                                <NavLink
                                  className={classNames(
                                    active
                                      ? "bg-gray-100 text-gray-900"
                                      : "text-gray-700",
                                    "block px-4 py-2 text-sm"
                                  )}
                                  tag={Link}
                                  to={`project/project-detail/${items.id}`}
                                >
                                  View Detail
                                </NavLink>
                              </NavItem>
                            )}
                          </Menu.Item>
                          <Menu.Item>
                            {({ active }) => (
                              <NavItem>
                                <NavLink
                                  className={classNames(
                                    active
                                      ? "bg-gray-100 text-gray-900"
                                      : "text-gray-700",
                                    "block px-4 py-2 text-sm"
                                  )}
                                >
                                  Cancel
                                </NavLink>
                              </NavItem>
                            )}
                          </Menu.Item>
                          <Menu.Item>
                            {({ active }) => (
                              <NavItem>
                                <NavLink
                                  className={classNames(
                                    active
                                      ? "bg-gray-100 text-gray-900"
                                      : "text-gray-700",
                                    "block px-4 py-2 text-sm"
                                  )}
                                >
                                  Delete
                                </NavLink>
                              </NavItem>
                            )}
                          </Menu.Item>
                        </ul>
                      </Menu.Items>
                    </Transition>
                  </Menu>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </>
  );
};
