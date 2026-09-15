async function getCurrentUser() {
  const { data: { user } } = await supabaseClient.auth.getUser();
  return user;
}

async function signUp(email, password) {
  const { data, error } = await supabaseClient.auth.signUp({ email, password });
  return { data, error };
}

async function signIn(email, password) {
  const { data, error } = await supabaseClient.auth.signInWithPassword({ email, password });
  return { data, error };
}

async function signOut() {
  await supabaseClient.auth.signOut();
  window.location.href = '/';
}
