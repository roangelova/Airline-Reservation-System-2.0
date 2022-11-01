import { agent} from "../agent";

export const Flight = {
    getAllFlights : () => agent.get('flights/getAll')
}