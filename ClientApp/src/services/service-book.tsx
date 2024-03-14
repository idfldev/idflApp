import { BOOK_URL } from "apis/api-path";
import axios from "axios";
import { FetchToken } from "hooks/fetch-token";
import { useEffect, useState } from "react"

function ServiceBook() {
    const [data, setData] = useState([] || null);

    useEffect(() => {
        const handleResponse = async () => {
            try {
                const response = await axios.get(BOOK_URL,{
                    headers:{
                        Authorization: FetchToken
                    }
                });
                setData(response.data);
            } catch (error) {
                console.error("Error fetching data:", error);
            }
        };
        handleResponse();
    }, []);

    return data;
}

export default ServiceBook
